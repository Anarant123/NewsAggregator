using Domain.Models;
using Domain.Models.Database;
using Domain.Models.Queries;
using Domain.Models.Result.BaseResult;
using Microsoft.EntityFrameworkCore;
using NewsAggregator.WebAPI.Repositories.BaseRepositories;

namespace NewsAggregator.WebAPI.Repositories;

public class NewsRepository : BaseRepository
{
    public NewsRepository(ApplicationContext context, ILogger<BaseRepository<Item>> logger)
        : base(context, logger)
    {
    }

    public async Task<BaseResult> Get(
        BaseQueryItemsParams queryParams)
    {
        var result = await Context.Items
            .AsNoTracking()
            .Where(i => (queryParams.FilterText != null 
                         && (i.Title.Contains(queryParams.FilterText)
                             || i.Description.Contains(queryParams.FilterText))))
            .Skip(queryParams.ItemsOnPage * (queryParams.PageNumber - 1))
            .Take(queryParams.ItemsOnPage)
            .ToListAsync();

        if (!result.Any())
        {
            return new FailResult("Новостей нет");
        }

        return new SuccessResult<List<Item>>(result);
    }
}