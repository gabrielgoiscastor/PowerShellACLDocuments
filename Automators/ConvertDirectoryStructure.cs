using PowerShellACLDocuments.DataModeling;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerShellACLDocuments.Automators
{
    public class ConvertDirectoryStructure
    {
        public ConvertDirectoryStructure()
        {

        }

        public List<Folder> readFolder(string folderPath)
        {
            DirectoryInfo info = new DirectoryInfo(folderPath);

            if(info.Exists == false)
            {
                return new List<Folder>();
            }

            return convertChildrenToFolderClass(info);
        }

        private List<Folder> convertChildrenToFolderClass(DirectoryInfo info)
        {
            List<Folder> returnObj = new List<Folder>();

            foreach (var item in info.GetDirectories())
            {
                Folder folder = new Folder();
                folder.Name = item.Name;
                folder.Folders = convertChildrenToFolderClass(item);
                returnObj.Add(folder);
            }

            return returnObj;
        }
    }
}
