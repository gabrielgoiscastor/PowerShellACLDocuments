using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerShellACLDocuments.DataModeling
{
    public class ACLSettingsGroup
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }
        public List<ACLSetting> Settings { get; set; }

        public ACLSettingsGroup()
        {
            Settings = new List<ACLSetting>();
        }

        public List<ACLSetting> CopySettings()
        {
            string serialized = Newtonsoft.Json.JsonConvert.SerializeObject(Settings);

            List<ACLSetting> deserialized = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ACLSetting>>(serialized);

            foreach (var item in deserialized)
            {
                item.BgColor = Color;
                item.GroupId = Id;
            }

            return deserialized;
        }
    }
}
