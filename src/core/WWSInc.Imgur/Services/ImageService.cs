using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using WWSInc.Imgur.Models;
using WWSInc.Imgur.Models.Data;

namespace WWSInc.Imgur.Services
{
    public class ImageService : AImgurService, IImageService
    {
     
        public ImageService(AuthTicketModel authTicket, ServicesSettingsModel imgurServicesSettings) : base(authTicket, imgurServicesSettings) { }

        public async Task<Response<ImageDataModel>> GetImageAsync(string imageHash)
        {            
            var uri = new Uri($"{Settings.ResolveApi(Settings.ImageApiPath)}/{imageHash}");
            return await GetAsync<ImageDataModel>(Request, uri);
        }

        public async Task<Response<List<ImageDataModel>>> GetImagesAsync()
        {
            var uri = new Uri(Settings.ResolveApi(Settings.ImagesApiPath));
            return await GetAsync<List<ImageDataModel>>(Request, uri);
        }

        public async Task<Response<ImageDataModel>> SaveImageAsync(Stream stream, string name, string fileName)
        {                      
            using (var content = new MultipartFormDataContent("Upload----"))
            {
                content.Add(new StreamContent(stream), name, fileName);
                var uri = new Uri(Settings.ResolveApi(Settings.UploadApiPath));
                return await PostAsync<ImageDataModel>(Request, content, uri);
            }
        }
    }
}
