using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerShellACLDocuments.DataModeling
{
    public class CopyFileSetting : BaseAction
    {
        public string Description { get; set; }
        public string From { get; set; }
        public string To { get; set; }

        public CopyFileSetting() : base("CopyFile")
        {

        }
    }
}
