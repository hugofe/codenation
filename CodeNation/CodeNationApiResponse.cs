using System.Net.Http;
using Newtonsoft.Json;

namespace CodeNation
{
    public class CodeNationApiResponses
    {
        public static Requisicao GetValue()
        {
            using(var client = new HttpClient())
            {
                var resultRequest = client.GetAsync("https://api.codenation.dev/v1/challenge/dev-ps/generate-data?token=b9a67f70a362d4f4bcb27f43f2ff674fe3854165").Result;
                var result = JsonConvert.DeserializeObject<Requisicao>(resultRequest.Content.ReadAsStringAsync().Result);
                return result;
            }
        }
        public static void SendValue()
        {

        }
    }
    public class Requisicao
    {
        public int numero_casa { get; set; }
        public string token { get; set; }
        public string cifrado { get; set; }     
        public string decifrado { get; set; }
        public string resumo_criptografico { get; set; }
    }

}