using System.IO;
using Newtonsoft.Json;

namespace CodeNation
{
    public class JsonFile
    {
        public static void GetValue()
        {
            var filePath = "./answer.json";
        }
        public static void WriteValue(Requisicao value)
        {
            var filePath = "./answer.json";

            using(StreamWriter sw = File.CreateText(filePath))
            {
                sw.Write(JsonConvert.SerializeObject(value));
            }
        }
    }
}