using Domain.Models.Database;

namespace Domain.Models.Respounce.Upload;

public class UploadRespounce
{
    public string Link { get; set; }
    public string RssVersion { get; set; }
    public int ItemsCount { get; set; }

    public UploadRespounce(RSS rss)
    {
        Link = rss.Channel.Link;
        RssVersion = rss.Version;
        ItemsCount = rss.Channel.Items.Count;
    }
}