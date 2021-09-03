using Newtonsoft.Json;
using WWSInc.Imgur.Models;

namespace Imgur_test.ServiceTest
{
    public abstract class BaseServiceTest<T>
    {
        public string JsonFileName { get; set;}
        public string JsonPathDir { get; set; }

        public string JsonText { get; set; }

        public BaseServiceTest(string jsonPathDir, string jsonFileName)
        {
            JsonPathDir = jsonPathDir;
            JsonFileName = jsonFileName;
            JsonText = System.IO.File.ReadAllText(JsonPathDir + JsonFileName);
        }

        public BaseServiceTest(string jsonPathDir)
        {
            JsonPathDir = jsonPathDir;            
        }

        public Response<T> GetResponse(string jsonFileName)
        {
            JsonText = System.IO.File.ReadAllText(JsonPathDir + jsonFileName);
            var result = JsonConvert.DeserializeObject<Response<T>>(JsonText);
            return result;
        }


        public Response<T> GetResponse()
        {
            var result = JsonConvert.DeserializeObject<Response<T>>(JsonText);
            return result;
        }
    }
}
