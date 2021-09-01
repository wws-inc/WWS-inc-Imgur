namespace WWSInc.Imgur.Services
{
    public interface IImgurServices : IImageService, IAlbumServices
    {
        //AlbumServices : AImgurService<AlbumDataModel>, IAlbumServices

        //Task<ImageModel> GetImageAsync(string imageHash);

        //Task<ImagesModel> GetImagesAsync();
        //Task<string> SaveImageAsync(Stream stream, string name, string fileName);

        // Task<Response<T>> SendAsync<T>(HttpRequestMessage request);
        
        AlbumServices Album { get; set; }

        ImageService Image { get; set; }
    }
}
