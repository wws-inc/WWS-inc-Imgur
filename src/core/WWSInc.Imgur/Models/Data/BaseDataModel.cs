using Newtonsoft.Json;

namespace WWSInc.Imgur.Models.Data
{
    public class BaseDataModel 
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string DateTime { get; set; }
        [JsonProperty("ad_config")]
        public AdConfigDataModel AdConfig { get; set; }
        public string DeleteHash { get; set; }
        [JsonProperty("account_id")]
        public int AccountId { get; set; }
        [JsonProperty("account_url")]
        public string? AccountUrl { get; set; }
        public string Link { get; set; }
        public bool? NSFW { get; set; }
        public string? Section { get; set; }
        public bool InGallery { get; set; }
        [JsonProperty("is_ad")]
        public bool IsAd { get; set; }
    }
}
