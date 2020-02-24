using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PowerShellACLDocuments.DataModeling
{
    public class ACLSetting : BaseAction
    {
        public ACLSetting() : base("ACL")
        {

        }

        public string ForWho { get; set; }
        public bool PermissionType { get; set; }
        public string PermissionLevel { get; set; }

        public bool FullControl { get; set; }
        public bool TraverseFolderExecuteFile { get; set; }
        public bool ListFolderReadData { get; set; }
        public bool ReadAttributes { get; set; }
        public bool ReadExtendedAttributes { get; set; }
        public bool CreateFilesWriteData { get; set; }
        public bool CreateFoldersAppendData { get; set; }
        public bool WriteAttributes { get; set; }
        public bool WriteExtendedAttributes { get; set; }
        public bool DeleteSubfoldersAndFiles { get; set; }
        public bool Delete { get; set; }
        public bool ReadPermissions { get; set; }
        public bool ChangePermissions { get; set; }
        public bool TakeOwnership { get; set; }

        public Guid GroupId { get; set; }

        public override string ToString()
        {
            string returnObj = "- " + this.ForWho + " | " + this.AllowOrDeny() + " | " + this.AccessRights();
            return returnObj;
        }

        public string AccessRights()
        {
            if (this.FullControl)
            {
                return "Traverse, ListDirectory, ReadData, ReadAttributes, ReadExtendedAttributes, CreateFiles, WriteData, CreateDirectories, AppendData, WriteAttributes, WriteExtendedAttributes, DeleteSubdirectoriesAndFiles, Delete, ReadPermissions, ChangePermissions, TakeOwnership";
            }

            List<string> accessRights = new List<string>();

            if (TraverseFolderExecuteFile) { accessRights.Add("Traverse"); }
            if (ListFolderReadData) { accessRights.Add("ListDirectory, ReadData"); }
            if (ReadAttributes) { accessRights.Add("ReadAttributes"); }
            if (ReadExtendedAttributes) { accessRights.Add("ReadExtendedAttributes"); }
            if (CreateFilesWriteData) { accessRights.Add("CreateFiles, WriteData"); }
            if (CreateFoldersAppendData) { accessRights.Add("CreateDirectories, AppendData"); }
            if (WriteAttributes) { accessRights.Add("WriteAttributes"); }
            if (WriteExtendedAttributes) { accessRights.Add("WriteExtendedAttributes"); }
            if (DeleteSubfoldersAndFiles) { accessRights.Add("DeleteSubdirectoriesAndFiles"); }
            if (Delete) { accessRights.Add("Delete"); }
            if (ReadPermissions) { accessRights.Add("ReadPermissions"); }
            if (ChangePermissions) { accessRights.Add("ChangePermissions"); }
            if (TakeOwnership) { accessRights.Add("TakeOwnership"); }

            return string.Join(", ",accessRights);
        }

        public string AllowOrDeny()
        {
            if (this.PermissionType)
            {
                return "Allow";
            }

            return "Deny";
        }

        public ACLPropagationAndInheritanceSettings PropagationAndInheritanceSettings()
        {
            ACLPropagationAndInheritanceSettings returnObj = new ACLPropagationAndInheritanceSettings();

            switch (PermissionLevel)
            {
                case "This folder only":
                    returnObj = new ACLPropagationAndInheritanceSettings("None", "None");
                    break;
                case "This folder, subfolder and files":
                    returnObj = new ACLPropagationAndInheritanceSettings("None", "ContainerInherit, ObjectInherit");
                    break;
                case "This folder and subfolders":
                    returnObj = new ACLPropagationAndInheritanceSettings("None", "ContainerInherit");
                    break;
                case "This folder and files":
                    returnObj = new ACLPropagationAndInheritanceSettings("None", "ObjectInherit");
                    break;
                case "Subfolders and files only":
                    returnObj = new ACLPropagationAndInheritanceSettings("InheritOnly", "ContainerInherit, ObjectInherit");
                    break;
                case "Subfolders only":
                    returnObj = new ACLPropagationAndInheritanceSettings("InheritOnly", "ContainerInherit");
                    break;
                case "Files only":
                    returnObj = new ACLPropagationAndInheritanceSettings("InheritOnly", "ObjectInherit");
                    break;
                default:
                    break;
            }

            return returnObj;
        }
    }

    public class ACLPropagationAndInheritanceSettings
    {
        public string Propagation { get; set; }
        public string Inheritance { get; set; }

        public ACLPropagationAndInheritanceSettings()
        {
            this.Propagation = "None";
            this.Inheritance = "None";
        }

        public ACLPropagationAndInheritanceSettings(string propagation, string inheritance)
        {
            Propagation = propagation;
            Inheritance = inheritance;
        }
    }
}
