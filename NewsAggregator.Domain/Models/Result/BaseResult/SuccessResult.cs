namespace Domain.Models.Result.BaseResult;

public class SuccessResult : BaseResult
{
    public SuccessResult()
    {
        Success = true;
    }
}

public class SuccessResult<T> : BaseResult<T>
{
    public SuccessResult(T item)
    {
        Success = true;
        Item = item;
    }
}