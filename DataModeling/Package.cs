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
        public string FolderInstructionsDefaultFileNme { get; set; }

        public Package()
        {
            this.Parameters = new List<Parameter>();
            this.Folders = new List<Folder>();
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
    }

    public class Folder
    {
        public string Name { get; set; }
        public List<BaseAction> Actions { get; set; }
        public List<Folder> Folders { get; set; }
        public string FolderInstructions { get; set; }

        public Folder()
        {
            this.Folders = new List<Folder>();
            this.Actions = new List<BaseAction>();
        }
    }
}
