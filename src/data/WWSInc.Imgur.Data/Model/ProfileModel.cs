using System;
using WWSInc.Imgur.Core.Models.Data;

namespace WWSInc.Imgur.Data.EF.Model
{
    [Serializable]
    public class ProfileModel : IProfileModel
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Bio { get; set; }
        public double Reputation { get; set; }
        public int Created { get; set; }
        public bool ProExpiration { get; set; }
    }
}