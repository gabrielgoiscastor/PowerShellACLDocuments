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

        public List<BaseAction> Actions { get; set; }
    }
}
