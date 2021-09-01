namespace WWSInc.Imgur.Models.Data
{
    public interface IBaseDataModel
    {
        string Id { get; set; }
        string Description { get; set; }
        string DateTime { get; set; }
        AdConfigDataModel AdConfig { get; set; }
        string DeleteHash { get; set; }
    }
}