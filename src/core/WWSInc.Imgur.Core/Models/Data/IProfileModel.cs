namespace WWSInc.Imgur.Core.Models.Data
{
    public interface IProfileModel
    {
        /// <summary>
        /// The account id for the username requested.
        /// </summary>
        int Id { get; set; }
        /// <summary>
        /// The account username, will be the same as requested in the URL
        /// </summary>
        string Url { get; set; }
        /// <summary>
        /// A basic description the user has filled out
        /// </summary>
        string Bio { get; set; }
        /// <summary>
        /// The reputation for the account, in it's numerical format.
        /// </summary>
        double Reputation { get; set; }
        /// <summary>
        /// The epoch time of account creation
        /// </summary>
        int Created { get; set; }
        /// <summary>
        /// False if not a pro user, their expiration date if they are.
        /// </summary>
        bool ProExpiration { get; set; }
    }
}
