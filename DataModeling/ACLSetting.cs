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

        public string Path { get; set; }
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

        public override string ToString()
        {
            string returnObj = this.Path + " | " + this.ForWho + " | Levels: " + Regex.Matches(Path, "\\").Count;
            return returnObj;
        }

    }
}
