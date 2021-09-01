namespace WWSInc.Imgur.Models
{
    public interface IResponseModel
    {
        bool Success { get; set; }
        string Status { get; set; }
    }
}
