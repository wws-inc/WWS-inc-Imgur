using WWSInc.Imgur.Core.Models.Data;

namespace WWSInc.Imgur.Data.SqlServer.Repositories
{
    public interface IImgurMediaRepository
    {
        void AddUpdateProfileAsync(IProfileModel profile);
    }
}
