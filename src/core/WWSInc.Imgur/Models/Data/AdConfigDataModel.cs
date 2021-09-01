using System.Collections.Generic;

namespace WWSInc.Imgur.Models.Data
{
    public class AdConfigDataModel
    {
        public List<string> SafeFlags { get; set; }
        public List<string> HighRiskFlags { get; set; }
        public List<string> UnsafeFlags { get; set; }
        public List<string> WallUnsafeFlags { get; set; }
        public bool ShowsAds { get; set; }
    }
}
