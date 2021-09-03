using Microsoft.EntityFrameworkCore;
using WWSInc.Imgur.Core.Models.Data;
using ImgurData = WWSInc.Imgur.Data.EF.Model;

namespace WWSInc.Imgur.Data.EF
{
    public abstract class BaseDbContext<T> : DbContext, IImgurDbContext where T : BaseDbContext<T>
    {
        /// <summary>
        /// Gets/sets whether the db context as been initialized. This
        /// is only performed once in the application lifecycle.
        /// </summary>
        private static volatile bool IsInitialized = false;

        /// <summary>
        /// The object mutext used for initializing the context.
        /// </summary>
        private static readonly object Mutex = new object();


        public BaseDbContext(DbContextOptions<T> options) : base(options)
        {
            if (!IsInitialized)
            {
                lock (Mutex)
                {
                    if (!IsInitialized)
                    {
                        // Migrate database
                        Database.Migrate();

                        IsInitialized = true;
                    }
                }
            }
        }


        public DbSet<ImgurData.ProfileModel> Profile { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {            
            mb.Entity<IProfileModel>().ToTable("Imgur_Profile");
            mb.Entity<IProfileModel>().HasKey(a => a.Id).HasName("Imgur_Profile_PrimaryKey_Id");            
        }
    }
}
