namespace WWSInc.Imgur.Core.Models
{
    public interface IResponseModel
    {
        bool Success { get; set; }
        string Status { get; set; }
    }
}
