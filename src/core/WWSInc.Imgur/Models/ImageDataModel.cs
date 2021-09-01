using Newtonsoft.Json;
using System.Collections.Generic;

namespace WWSInc.Imgur.Models
{
    public class ImageDataModel : ImgurModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Datetime { get; set; }
        public string Type { get; set; }
        public bool Animated { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Size { get; set; }
        public int Views { get; set; }
        public int? Vote { get; set; }
        public bool Favorite { get; set; }
        public string? NSFW { get; set; }
        public string? Section { get; set; }
        public string? AccountUrl { get; set; }

        [JsonProperty("account_id")]
        public int AccountId { get; set; }
        [JsonProperty("is_ad")]
        public bool IsAd { get; set; }
        [JsonProperty("is_most_viral")]
        public bool InMostViral { get; set; }
        [JsonProperty("has_sound")]
        public bool HasSound { get; set; }
        public List<string> Tags { get; set; }
        [JsonProperty("ad_type")]
        public string AdType { get; set; }
        [JsonProperty("ad_url")]
        public string AdUrl { get; set; }
        public int Edited { get; set; }
        public bool InGallery { get; set; }
      
        public string Name { get; set; }
        public string Link { get; set; }
        [JsonProperty("ad_config")]
        public AdConfigModel AdConfig { get; set; }
    }
}
