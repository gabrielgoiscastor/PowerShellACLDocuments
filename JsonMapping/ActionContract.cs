using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PowerShellACLDocuments.DataModeling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerShellACLDocuments.JsonMapping
{
    class ActionContract : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(BaseAction));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            Newtonsoft.Json.Linq.JObject jo = Newtonsoft.Json.Linq.JObject.Load(reader);
            if (jo["ActionType"].Value<string>() == "ACL")
                return jo.ToObject<ACLSetting>(serializer);

            if (jo["ActionType"].Value<string>() == "CopyFile")
                return jo.ToObject<CopyFileSetting>(serializer);

            return null;
        }

        public override bool CanWrite
        {
            get { return false; }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
