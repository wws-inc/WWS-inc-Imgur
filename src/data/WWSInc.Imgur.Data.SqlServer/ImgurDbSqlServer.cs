using Microsoft.EntityFrameworkCore;
using WWSInc.Imgur.Data.EF;

namespace WWSInc.Imgur.Data.SqlServer
{
    public class ImgurDbSqlServer : BaseDbContext<ImgurDbSqlServer>
    {
        public ImgurDbSqlServer(DbContextOptions<ImgurDbSqlServer> options) : base(options)
        {

        }
    }
}
