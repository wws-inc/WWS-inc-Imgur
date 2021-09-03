using System.Threading.Tasks;
using ImgurData = WWSInc.Imgur.Data.EF.Model;

namespace WWSInc.Imgur.Data.EF.Repository
{
    public interface IProfileRepository
    {
        Task AddUpdateAsync(ImgurData.ProfileModel profile);
    }
}
