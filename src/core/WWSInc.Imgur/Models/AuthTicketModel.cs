using System;

namespace WWSInc.Imgur.Models
{
    public class AuthTicketModel
    {        
        public string AuthenticationScheme { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string TokenType { get; set; }
        public DateTime TokenExpires { get; set; }
        public DateTime Issued { get; set; }
        public DateTime Expires { get; set; }
        public string TokenNames { get; set; }
    }
}
