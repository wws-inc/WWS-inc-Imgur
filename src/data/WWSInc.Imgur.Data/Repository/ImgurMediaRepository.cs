using WWSInc.Imgur.Core.Models.Data;
using WWSInc.Imgur.Data.EF;

namespace WWSInc.Imgur.Data.SqlServer.Repositories
{
    public class ImgurMediaRepository : IImgurMediaRepository
    {
        private readonly IImgurDbContext _context;

        public ImgurMediaRepository(IImgurDbContext context)
        {
            _context = context;
        }

        public async void AddUpdateProfileAsync(IProfileModel profile)
        {
            //await _context.Profile.AddAsync(profile);
            //await _context.SaveChangesAsync();
        }       
    }
}
