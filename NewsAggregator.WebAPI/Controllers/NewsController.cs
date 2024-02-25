using Domain.Models.Queries;
using Domain.Models.Result.BaseResult;
using Microsoft.AspNetCore.Mvc;
using NewsAggregator.WebAPI.Controllers.BaseControllers;
using NewsAggregator.WebAPI.Repositories;

namespace NewsAggregator.WebAPI.Controllers;

[ApiController]
public class NewsController : BaseController
{
    private readonly NewsRepository _newsRepository;
    
    public NewsController(ILogger<NewsController> logger, NewsRepository newsRepository) 
        : base(logger)
    {
        _newsRepository = newsRepository;
    }
    
    /// <summary>
    /// Пополнение аггрегатора новостями
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    [HttpGet]
    [Route("News")]
    public async Task<ActionResult<BaseResult>> Get(
        [FromQuery] BaseQueryItemsParams queryParams)
    {
        try
        {
            var result = await _newsRepository.Get(queryParams);

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }
        catch (Exception exception)
        {
            Logger.LogError(exception.Message);
            return BadRequest(new FailResult()
            {
                Error = exception.Message
            });
        }
    }
}