using System.Collections.Generic;
using System.Threading.Tasks;
using WWSInc.Imgur.Core.Models;

namespace WWSInc.Imgur.Core.Services
{
    public interface IAlbumServices
    {
        /// <summary>
        /// reference: https://apidocs.imgur.com/#8f89bd41-28a1-4624-9393-95e12cec509a
        /// </summary>
        /// <param name="imageIds">The image ids that you want to be included in the album.</param>
        /// <param name="deleteIdHashes">The deletehashes of the images that you want to be included in the album.</param>
        /// <param name="title">The title of the album</param>
        /// <param name="description">The description of the album</param>
        /// <param name="privacy">Sets the privacy level of the album. Values are : public | hidden | secret. Defaults to user's privacy settings for logged in users.</param>
        /// <param name="coverId">The ID of an image that you want to be the cover of the album</param>
        /// <returns></returns>
        Task<Response<AlbumDataModel>> CreateAlbumAsync(List<int> imageIds, List<int> deleteIdHashes, string title, string description, Privacy privacy, int coverId);

        /// <summary>
        /// id is required
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Response<AlbumDataModel>> GetAlbumsAsync(string albumId);
    }
}
