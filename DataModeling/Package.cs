using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerShellACLDocuments.DataModeling
{
    public class Package
    {
        public string Name { get; set; }
        public string BasePath { get; set; }

        public List<Parameter> Parameters { get; set; }
        public List<Folder> Folders { get; set; }
        public List<ACLSettingsGroup> ACLSettingsGroups { get; set; }
        public string FolderInstructionsDefaultFileName { get; set; }

        public Package()
        {
            this.Parameters = new List<Parameter>();
            this.Folders = new List<Folder>();
            ACLSettingsGroups = new List<ACLSettingsGroup>();
        }

        public Folder FindFolder(string path, string separator = "\\")
        {
            string[] brokenPath = path.Split(new string[] { separator }, StringSplitOptions.RemoveEmptyEntries);

            List<Folder> folderList = Folders;

            for (int i = 0; i < brokenPath.Length - 1; i++)
            {
                string el = brokenPath[i];
                folderList = folderList.Where(x => x.Name == el).First().Folders;
            }

            return folderList.Where(x => x.Name == brokenPath.Last()).FirstOrDefault();
        }

        public Folder FindParent(string path, string separator = "\\")
        {
            string[] brokenPath = path.Split(new string[] { separator }, StringSplitOptions.RemoveEmptyEntries);

            List<Folder> folderList = Folders;
            if (brokenPath.Length == 1)
            {
                return new Folder() { Name = "", Folders = folderList };
            }

            //all the way up to the almost last
            string[] copyObj = new string[brokenPath.Length - 1];
            for (int i = 0; i < copyObj.Length; i++)
            {
                copyObj[i] = brokenPath[i];
            }
            brokenPath = copyObj;

            for (int i = 0; i < brokenPath.Length - 1; i++)
            {
                string el = brokenPath[i];
                folderList = folderList.Where(x => x.Name == el).FirstOrDefault().Folders;
            }

            return folderList.Where(x => x.Name == brokenPath.Last()).FirstOrDefault();
        }

        public string FolderInstructionsDefaultFileNameValidated()
        {
            if (FolderInstructionsDefaultFileName.ToLower().EndsWith(".txt")){
                return FolderInstructionsDefaultFileName;
            }

            return FolderInstructionsDefaultFileName + ".txt";
        }
    }

    public class Folder
    {
        public string Name { get; set; }
        public List<BaseAction> Actions { get; set; }
        public List<Folder> Folders { get; set; }
        public string FolderInstructions { get; set; }
        public List<Guid> AppliedACLGroup { get; set; }

        public Folder()
        {
            Folders = new List<Folder>();
            Actions = new List<BaseAction>();
            AppliedACLGroup = new List<Guid>();
        }

        public void UpdateIfAnyInherited(List<ACLSettingsGroup> updatedGroups)
        {
            List<Guid> updatedIds = updatedGroups.Select(x => x.Id).ToList();

            UpdateIfAnyInherited(updatedGroups, updatedIds);
        }

        public void UpdateIfAnyInherited(List<ACLSettingsGroup> updatedGroups, List<Guid> updatedIds)
        {
            // if this folder have any of the applied groups
            if(this.AppliedACLGroup.Where(x => updatedIds.Contains(x)).Any())
            {
                var remove = Actions.Where(x => x is ACLSetting).Where(x => updatedIds.Contains((x as ACLSetting).GroupId)).ToList();

                for (int i = remove.Count - 1; i >= 0; i--)
                {
                    Actions.Remove(remove[i]);
                }

                foreach (var group in this.AppliedACLGroup.Where(x => updatedIds.Contains(x)))
                {
                    var realGroup = updatedGroups.Where(x => x.Id == group).FirstOrDefault();

                    if(realGroup == null)
                    {
                        continue;
                    }
                    this.Actions.AddRange(realGroup.CopySettings());
                }
            }

            // apply to children
            foreach (var item in Folders)
            {
                item.UpdateIfAnyInherited(updatedGroups, updatedIds);
            }
        }
    }
}
