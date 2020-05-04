using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SpeedyIntegraion
{
    class JsonHelper
    {
        public static string To<T>(T obj)
        {
            string retVal = null;
            retVal = JsonConvert.SerializeObject(obj, obj.GetType(), Formatting.Indented, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                DateFormatString = "yyyy-MM-dd HH:mm:ss",
                DefaultValueHandling = DefaultValueHandling.Ignore,
            });
            return retVal;

        }

        public static T From<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                DateFormatString = "yyyy-MM-dd HH:mm:ss"
            });
        }

        public class DoubleFormatConverter : JsonConverter
        {
            public override bool CanConvert(Type objectType)
            {
                return (objectType == typeof(double));
            }

            public override void WriteJson(JsonWriter writer, object value,
                                           JsonSerializer serializer)
            {
                writer.WriteValue(string.Format(CultureInfo.InvariantCulture, "{0:0.00}", value));
            }

            public override bool CanRead
            {
                get { return false; }
            }

            public override object ReadJson(JsonReader reader, Type objectType,
                                         object existingValue, JsonSerializer serializer)
            {
                throw new NotImplementedException();
            }
        }
    }
}
