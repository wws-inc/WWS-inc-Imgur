using Newtonsoft.Json;
using System.Collections.Generic;
using WWSInc.Imgur.Models.Data;

namespace WWSInc.Imgur.Models
{
    public class AlbumDataModel : BaseDataModel
    {
        public string Cover { get; set; }
        [JsonProperty("cover_edited")]
        public string CoverEdited { get; set; }
        [JsonProperty("cover_width")]
        public int CoverWidth { get; set; }
        [JsonProperty("cover_height")]
        public int CoverHeight { get; set; }
        public string Privacy { get; set; }
        public string Layout { get; set; }
        public int Views { get; set; }
        public bool Favorite { get; set; }
        [JsonProperty("images_count")]
        public int ImagesCount { get; set; }
        [JsonProperty("include_album_ads")]
        public bool IncludeAlbumAds { get; set; }
        [JsonProperty("is_album")]
        public bool IsAlbum { get; set; }
        public List<ImageDataModel> Images { get; set; }
    }
}