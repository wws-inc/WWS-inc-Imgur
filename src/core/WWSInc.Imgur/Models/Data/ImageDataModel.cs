using Newtonsoft.Json;
using System.Collections.Generic;

namespace WWSInc.Imgur.Models.Data
{
    public class ImageDataModel : BaseDataModel
    {
        public string Type { get; set; }
        public bool Animated { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Size { get; set; }
        public int Views { get; set; }
        public int? Vote { get; set; }
        public bool Favorite { get; set; }
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
        public string Name { get; set; }
        public int Bandwidth { get; set; }        
    }
}
