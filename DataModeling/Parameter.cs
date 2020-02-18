using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerShellACLDocuments.DataModeling
{
    public class Parameter
    {
        public string Name { get; set; }

        public bool IsInput { get; set; }

        public string Value { get; set; }
    }
}
