using Microsoft.EntityFrameworkCore;
using WWSInc.Imgur.Core.Models.Data;
using ImgurData = WWSInc.Imgur.Data.EF.Model;

namespace WWSInc.Imgur.Data.EF
{
    public abstract class BaseDbContext<T> : DbContext, IImgurDbContext where T : BaseDbContext<T>
    {
        public DbSet<ImgurData.ProfileModel> Profile { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {            
            mb.Entity<IProfileModel>().ToTable("Imgur_Profile");
            mb.Entity<IProfileModel>().HasKey(a => a.Id).HasName("Imgur_Profile_PrimaryKey_Id");            
        }
    }
}
