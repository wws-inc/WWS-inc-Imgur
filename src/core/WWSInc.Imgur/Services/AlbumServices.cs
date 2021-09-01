using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WWSInc.Imgur.Models;

namespace WWSInc.Imgur.Services
{
    public class AlbumServices : AImgurService, IAlbumServices
    {
        public AlbumServices(AuthTicketModel authTicket, ServicesSettingsModel imgurServicesSettings) : base(authTicket, imgurServicesSettings) { }

        public async Task<Response<AlbumDataModel>> GetAlbumsAsync(string albumId)
        {
            var stringuri = $"{Settings.ResolveApi(Settings.AlbumApiPath)}/{albumId}";
            var uri = new Uri(stringuri);

            return await GetAsync<AlbumDataModel>(Request, uri);
        }

        public async Task<Response<AlbumDataModel>> CreateAlbumAsync(List<int> imageIds, List<int> deleteIdHashes, string title, string description, Privacy privacy, int coverId)
        {
            using (var content = new MultipartFormDataContent("Create Album"))
            {
                if (string.IsNullOrEmpty(title)) throw new ArgumentNullException("Album title is null");

                content.Add(new StringContent(title), "title");

                content.Add(new StringContent(Enum.GetName(privacy)), "privacy");

                if (!string.IsNullOrEmpty(description))
                {
                    content.Add(new StringContent(description), "description");
                }

                if (coverId > 0)
                {
                    content.Add(new StringContent(coverId.ToString()), "cover");
                }

                if (imageIds.Any())
                {
                    var ids = $"[{string.Join(",", imageIds)}]";
                    content.Add(new StringContent(ids), "ids");
                }

                if (deleteIdHashes.Any())
                {
                    var deletehashes = $"[{string.Join(",", deleteIdHashes)}]";
                    content.Add(new StringContent(deletehashes), "deletehashes");
                }

                var uri = new Uri(Settings.ResolveApi(Settings.AlbumApiPath));

                return await PostAsync<AlbumDataModel>(Request, content, uri);
            }
        }
    }
}
