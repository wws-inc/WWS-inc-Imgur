using Microsoft.EntityFrameworkCore;
using WWSInc.Imgur.Data.EF;
using WWSInc.Imgur.Data.EF.Model;

namespace WWSInc.Imgur.Data.SqlServer
{
    public class ImgurDbSqlExpress : BaseDbContext<ImgurDbSqlExpress>
    {
        public ImgurDbSqlExpress(DbContextOptions<ImgurDbSqlExpress> options) : base(options)
        {
            
        }
    }
}
