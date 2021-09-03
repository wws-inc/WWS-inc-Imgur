using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using WWSInc.Imgur.Core.Models;
using WWSInc.Imgur.Core.Models.Data;

namespace WWSInc.Imgur.Core.Services
{
    public interface IImageService
    {
        Task<Response<ImageDataModel>> GetImageAsync(string imageHash);

        Task<Response<List<ImageDataModel>>> GetImagesAsync();


        Task<Response<ImageDataModel>> SaveImageAsync(Stream stream, string name, string fileName);
    }
}