using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LevineNarrative.Blocks;
using Newtonsoft.Json;

namespace LevineNarrative.JSONConverter
{
    public class PassionConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return serializer.Deserialize(reader, typeof (BasePassion));
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof (IPassion);
        }
    }
}
