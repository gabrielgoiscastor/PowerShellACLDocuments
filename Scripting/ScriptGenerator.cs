using PowerShellACLDocuments.DataModeling;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerShellACLDocuments.Scripting
{
    public class ScriptGenerator
    {
        private string aclSettingBase;
        private string newFolderBase;
        private string copyFileBase;

        public ScriptGenerator()
        {
            string systemBasePath = AppDomain.CurrentDomain.BaseDirectory + "Scripting\\";
            aclSettingBase = File.ReadAllText(systemBasePath + "ACLSetting.txt");
            newFolderBase = File.ReadAllText(systemBasePath + "NewFolderIfNotExistent.txt");
            copyFileBase = File.ReadAllText(systemBasePath + "CopyFile.txt");
        }

        public string generateScript(Package package)
        {
            StringBuilder builder = new StringBuilder();

            string basePath = package.BasePath;

            foreach (var item in package.Folders)
            {
                builder.Append(mixing(item, basePath));
                continue;
            }

            return builder.ToString();
        }

        private string mixing(Folder createFolder, string basePath)
        {
            string returnObj = "";

            //create folder if not existent
            returnObj = newFolderBase.Replace("@basePath", basePath).Replace("@folderPath", createFolder.Name);

            returnObj += "\n\n";

            string fullPath = basePath + createFolder.Name + @"\";

            //create actions
            if (createFolder.Actions != null)
            {
                foreach (var item in createFolder.Actions)
                {
                    if (item is ACLSetting)
                    {
                        returnObj += mixing(item as ACLSetting, fullPath);
                    }
                }
            }

            //add inner folders
            if (createFolder.Folders != null)
            {
                foreach (var item in createFolder.Folders)
                {
                    returnObj += mixing(item, fullPath);
                }
            }

            return returnObj;
        }

        private string mixing(ACLSetting acl, string aclPath)
        {
            string returnObj = "";

            //generate ACL
            string aclTXT = aclSettingBase;
            ACLPropagationAndInheritanceSettings propagationVariable = acl.PropagationAndInheritanceSettings();

            aclTXT = aclTXT.Replace("@actionPath", aclPath);
            aclTXT = aclTXT.Replace("@who", acl.ForWho);
            aclTXT = aclTXT.Replace("@rights", acl.AccessRights());
            aclTXT = aclTXT.Replace("@allowDeny", acl.AllowOrDeny());
            aclTXT = aclTXT.Replace("@inherit", propagationVariable.Inheritance);
            aclTXT = aclTXT.Replace("@propagation", propagationVariable.Propagation);

            returnObj += aclTXT;
            returnObj += "\n\n";

            return returnObj;
        }
    }
}
