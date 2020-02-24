using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerShellACLDocuments.DataModeling
{
    public class ACLSettingsGroup
    {
        public string Name { get; set; }
        public List<ACLSetting> Settings { get; set; }
    }
}
