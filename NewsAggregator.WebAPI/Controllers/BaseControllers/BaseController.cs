using Microsoft.AspNetCore.Mvc;

namespace NewsAggregator.WebAPI.Controllers.BaseControllers;

public class BaseController : ControllerBase
{
    protected readonly ILogger<BaseController> Logger;
    
    
    public BaseController(ILogger<BaseController> logger)
    {
        Logger = logger;
    }
}