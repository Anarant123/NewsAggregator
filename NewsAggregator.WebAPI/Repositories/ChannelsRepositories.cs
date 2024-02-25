using System.Xml.Serialization;
using Domain.Models;
using Domain.Models.Database;
using Domain.Models.Respounce.Upload;
using Domain.Models.Result.BaseResult;
using NewsAggregator.WebAPI.Repositories.BaseRepositories;

namespace NewsAggregator.WebAPI.Repositories;

public class ChannelsRepositories : BaseRepository
{
    public ChannelsRepositories(ApplicationContext context, ILogger<BaseRepository<Channel>> logger)
        : base(context, logger)
    {
    }

    public async Task<BaseResult> Upload(string url)
    {
        using var httpClient = new HttpClient();
        using var response = await httpClient.GetAsync(url);
        if (!response.IsSuccessStatusCode)
        {
            return new FailResult("Нет ответа по данному RSS каналу");
        }

        await using var stream = await response.Content.ReadAsStreamAsync();
        var serializer = new XmlSerializer(typeof(RSS));
        var rss = (RSS)serializer.Deserialize(stream);
        
        Context.Channels.Add(rss.Channel);
        
        return await Context.SaveChangesAsync() switch
        {
            0 => new FailResult("Произошла ошибка при сохранении данных"),
            _ => new SuccessResult<UploadRespounce>(new UploadRespounce(rss))
        };
    }
}