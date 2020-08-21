using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;

namespace APITester
{
    public class Program
    {
        static void Main(string[] args)
        {
            APIcaller caller = new APIcaller();
            caller.Run();
        }


    }

    public class APIcaller
    {

        public async Task<LicenceModel> getLicence(string uniqueId)
        {
            LicenceModel licence = new LicenceModel();
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.PostAsync("https://localhost:44356/api/GetLicenceWithUniqueKey/" + uniqueId, null);
            response.EnsureSuccessStatusCode();
            string result = await response.Content.ReadAsStringAsync();
            licence = JsonConvert.DeserializeObject<LicenceModel>(result);
            return licence;
        }

        public void Run()
        {
            string uniqueId = "3f2f6g32g-32g43-34g2-dsf76h-34";
            LicenceModel lm = getLicence(uniqueId).GetAwaiter().GetResult();
            string jsonString = JsonConvert.SerializeObject(lm);
            Console.WriteLine(jsonString);
            Console.ReadLine();
        }
    }
}
