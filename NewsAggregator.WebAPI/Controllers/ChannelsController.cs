using Domain.Models.Result.BaseResult;
using Microsoft.AspNetCore.Mvc;
using NewsAggregator.WebAPI.Controllers.BaseControllers;
using NewsAggregator.WebAPI.Repositories;

namespace NewsAggregator.WebAPI.Controllers;

[ApiController]
public class ChannelsController : BaseController
{
    private readonly ChannelsRepositories _channelsRepositories;
    
    public ChannelsController(ILogger<ChannelsController> logger, ChannelsRepositories channelsRepositories) 
        : base(logger)
    {
        _channelsRepositories = channelsRepositories;
    }

    /// <summary>
    /// Пополнение аггрегатора новостями
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("Upload")]
    public async Task<ActionResult<BaseResult>> Upload(
        [FromQuery] string url)
    {
        try
        {
            var result = await _channelsRepositories.Upload(url);

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