namespace Domain.Models.Result.BaseResult;

public class FailResult : BaseResult
{
    public FailResult()
    {
        Success = false;
        Error = "Unknown error";
    }

    public FailResult(string error)
    {
        Success = false;
        Error = error;
    }
}

