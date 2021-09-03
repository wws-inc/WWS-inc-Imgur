using Newtonsoft.Json;

namespace WWSInc.Imgur.Core.Models
{
    public class Response<T>
    {
        [JsonProperty("data")]
        public T Data { get; set; }
        public bool Success { get; set; }
        public string Status { get; set; }
    }
}
