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
        private string createManualFile;

        public ScriptGenerator()
        {
            string systemBasePath = AppDomain.CurrentDomain.BaseDirectory + "Scripting\\";
            aclSettingBase = File.ReadAllText(systemBasePath + "ACLSetting.txt");
            newFolderBase = File.ReadAllText(systemBasePath + "NewFolderIfNotExistent.txt");
            copyFileBase = File.ReadAllText(systemBasePath + "CopyFile.txt");
            createManualFile = File.ReadAllText(systemBasePath + "GenerateTXTFileWithContent.txt");
        }

        public string generateScript(Package package)
        {
            StringBuilder builder = new StringBuilder();

            string basePath = package.BasePath;

            foreach (var item in package.Folders)
            {
                builder.Append(mixing(item, basePath, package));
                continue;
            }

            return builder.ToString();
        }

        private string mixing(Folder createFolder, string basePath, Package package)
        {
            string returnObj = "";

            // create folder if not existent
            returnObj = newFolderBase.Replace("@basePath", basePath).Replace("@folderPath", createFolder.Name);

            returnObj += "\n\n";

            string fullPath = basePath + createFolder.Name + @"\";

            // create intructions
            if (string.IsNullOrEmpty(createFolder.FolderInstructions) == false && package.FolderInstructionsDefaultFileNameValidated() != ".txt")
            {
                string manual = createFolder.FolderInstructions;
                string[] escapeChars = new string[] { "@", "!", "(", ")", "|", "&", "\"", "," };

                ////PS
                foreach (var character in escapeChars)
                {
                    manual = manual.Replace(character, "`" + character);
                }

                returnObj += createManualFile.Replace("@filePath", basePath + createFolder.Name + "\\" + package.FolderInstructionsDefaultFileNameValidated()).Replace("@fileContent", manual);
            }

            // create actions
            if (createFolder.Actions != null)
            {
                foreach (var item in createFolder.Actions)
                {
                    if (item is ACLSetting)
                    {
                        ACLSetting itemAsAcl = item as ACLSetting;
                        // check if ACL action has a inner parameter as it's target
                        returnObj += mixing(item as ACLSetting, fullPath, package);
                    }
                }
            }

            // add inner folders
            if (createFolder.Folders != null)
            {
                foreach (var item in createFolder.Folders)
                {
                    returnObj += mixing(item, fullPath, package);
                }
            }

            return returnObj;
        }

        private string mixing(ACLSetting acl, string aclPath, Package package)
        {
            string returnObj = "";

            //generate ACL
            string aclTXT = aclSettingBase;
            ACLPropagationAndInheritanceSettings propagationVariable = acl.PropagationAndInheritanceSettings();

            aclTXT = aclTXT.Replace("@actionPath", aclPath);
            
            aclTXT = aclTXT.Replace("@rights", acl.AccessRights());
            aclTXT = aclTXT.Replace("@allowDeny", acl.AllowOrDeny());
            aclTXT = aclTXT.Replace("@inherit", propagationVariable.Inheritance);
            aclTXT = aclTXT.Replace("@propagation", propagationVariable.Propagation);

            if (package.Parameters.Where(x => x.Name == acl.ForWho).Any())
            {
                Parameter par = package.Parameters.Where(x => x.Name == acl.ForWho).First();

                string[] values = par.Value.Replace("\r","").Split(new char[] { '\n' });

                foreach (var item in values)
                {
                    string innerAclTXT = aclTXT;
                    innerAclTXT = innerAclTXT.Replace("@who", item);
                    returnObj += innerAclTXT;
                    returnObj += "\n\n";
                }
            }
            else
            {
                aclTXT = aclTXT.Replace("@who", acl.ForWho);
                returnObj += aclTXT;
                returnObj += "\n\n";
            }

            return returnObj;
        }
    }
}
