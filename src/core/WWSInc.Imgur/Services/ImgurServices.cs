using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using WWSInc.Imgur.Models;

/// <summary>
/// WWS Inc. Imgur primary service. 
/// Contains all imgur related specific services.
/// </summary>
namespace WWSInc.Imgur.Services
{
    public class ImgurServices: IImgurServices
    {
        public ImageService Image { get; set; }
        public AlbumServices Album { get; set; }

        public ImgurServices(AuthTicketModel authTicket,
            ServicesSettingsModel imgurServicesSettings)
        {
            Image = new ImageService(authTicket, imgurServicesSettings);
            Album = new AlbumServices(authTicket, imgurServicesSettings);
        }


        public async Task<Response<AlbumDataModel>> CreateAlbumAsync(List<int> imageIds, List<int> deleteIdHashes, string title, string description, Privacy privacy, int coverId)
        {
            return await Album.CreateAlbumAsync(imageIds, deleteIdHashes, title, description, privacy, coverId);            
        }

        public async Task<Response<ImageDataModel>> GetImageAsync(string imageHash)
        {
            return await Image.GetImageAsync(imageHash);
        }

        public async Task<Response<List<ImageDataModel>>> GetImagesAsync()
        {
            return await Image.GetImagesAsync();
        }

        public Task<Response<ImageDataModel>> SaveImageAsync(Stream stream, string name, string fileName)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Response<AlbumDataModel>> GetAlbumsAsync(string albumId)
        {
            return await Album.GetAlbumsAsync(albumId);
        }
    }
}
