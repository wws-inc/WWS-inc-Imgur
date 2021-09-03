using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;
using ImgurData = WWSInc.Imgur.Data.EF.Model;

namespace WWSInc.Imgur.Data.EF
{
    public interface IImgurDbContext : IDisposable
    {
        #region Properties
        DbSet<ImgurData.ProfileModel> Profile { get; set; }
        #endregion
        /// <summary>
        /// Saves the changes made to the context.
        /// </summary>
        int SaveChanges();

        /// <summary>
        /// Saves the changes made to the context.
        /// </summary>
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}