using System.Net.Http.Headers;

namespace WWSInc.Imgur.Models
{
    public class ServicesSettingsModel
    {
        public string ApiEndpoint { get; set; } = "https://api.imgur.com/3";
        public string UserAgentName { get; set; } = "WWS Inc. Imgur Service";
        public MediaTypeWithQualityHeaderValue Accept { get; set; } = new MediaTypeWithQualityHeaderValue("application/json");

        public string ImageApiPath { get; set; } = "/image";
        public string ProfileApiPath { get; set; } = "/account/me";
        public string ImagesApiPath { get; set; } = "/account/me/images";
        public string AlbumApiPath { get; set; } = "/album";

        public string UploadApiPath { get; set; } = "/upload";

        public string ResolveApi(string path)
        {
            return $"{ApiEndpoint}{path}";
        }
    }
}
