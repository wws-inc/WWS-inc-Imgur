using System.Threading.Tasks;
using ImgurData = WWSInc.Imgur.Data.EF.Model;

namespace WWSInc.Imgur.Data.EF.Repository
{
    public class ProfileRepository : IProfileRepository
    {
        private IImgurDbContext _context;

        public ProfileRepository(IImgurDbContext context)
        {
            _context = context;
        }

        public async Task AddUpdateAsync(ImgurData.ProfileModel profile)
        {
            _context.Profile.Add(profile);
            await _context.SaveChangesAsync();
        }
    }
}
