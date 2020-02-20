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
            //StringBuilder builder = new StringBuilder();

            //foreach (var item in workingFolder.Actions)
            //{
            //    if(item is ACLSetting)
            //    {
            //        builder.Append(mixing(item as ACLSetting, package));
            //        continue;
            //    }
            //}

            //return builder.ToString();

            throw new NotImplementedException();
        }

        private string mixing(ACLSetting acl, Package pack)
        {
            string returnObj = "";

            //create folder if not existent
            returnObj = newFolderBase.Replace("@basePath",pack.BasePath).Replace("@actionPath", acl.Path);

            //generate ACL
            string aclTXT = aclSettingBase;
            ACLPropagationAndInheritanceSettings propagationVariable = acl.PropagationAndInheritanceSettings();

            aclTXT = aclTXT.Replace("@basePath", pack.BasePath);
            aclTXT = aclTXT.Replace("@actionPath", acl.Path);
            aclTXT = aclTXT.Replace("@who", acl.ForWho);
            aclTXT = aclTXT.Replace("@rights", acl.AccessRights());
            aclTXT = aclTXT.Replace("@allowDeny", acl.AllowOrDeny());
            aclTXT = aclTXT.Replace("@inherit", propagationVariable.Inheritance);
            aclTXT = aclTXT.Replace("@propagation", propagationVariable.Propagation);

            returnObj += "\n\n";
            returnObj += aclTXT;
            returnObj += "\n\n";

            return returnObj;
        }
    }
}
