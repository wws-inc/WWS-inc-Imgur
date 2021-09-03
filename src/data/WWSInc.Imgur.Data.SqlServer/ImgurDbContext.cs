using Microsoft.EntityFrameworkCore;

namespace WWSInc.Imgur.Data.SqlServer
{
    public class BaseImgurDbContext : DbContext
    {        
        public ImgurDbContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {
            
        }
     
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<BalitaOnlineAuthTicket>().ToTable("BalitaOnline_AuthTickets");
            //builder.Entity<BalitaOnlineAuthTicket>().HasKey(a => a.AuthenticationScheme).HasName("BalitaOnline_AuthTicket_PrimaryKey_Id");
            //builder.Entity<BalitaOnlineAuthTicket>().Property(a => a.AuthenticationScheme).IsRequired(true);
            //builder.Entity<BalitaOnlineAuthTicket>().Property(a => a.AccessToken).IsRequired(true);
            //builder.Entity<BalitaOnlineAuthTicket>().Property(a => a.RefreshToken).IsRequired(true);
        }
    }
}
