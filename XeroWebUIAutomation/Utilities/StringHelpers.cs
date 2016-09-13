using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace XeroWebUIAutomation.Utilities
{
    public class JsonHandler
    {
        public static string jsondata;

        public static void DeserializeDataFromFile<T>(string filePath, ref T deserializedDataContainer)
        {
            jsondata = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, filePath));
            Deserializer<T>(ref deserializedDataContainer, filePath);
        }
        private static void Deserializer<T>(ref T deserializedDataContainer, string URL = "")
        {
            try
            {
                JObject jsonParsed = JObject.Parse(jsondata);

                jsondata = jsonParsed["value"].ToString();

                deserializedDataContainer = JsonConvert.DeserializeAnonymousType<T>(jsondata, deserializedDataContainer);
            }
            catch
            {
                deserializedDataContainer = JsonConvert.DeserializeAnonymousType<T>(jsondata, deserializedDataContainer);
            }
        }
    }
}
