namespace WWSInc.Imgur.Core.Models.Data
{
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
