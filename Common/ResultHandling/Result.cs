namespace CSharpAoc.Common.ResultHandling.Result;

public abstract record Result<TValue, TError>
{
    public sealed record Success(TValue Value) : Result<TValue, TError>;

    public sealed record Failure(TError Error) : Result<TValue, TError>;

    public static Success Succ(TValue value)
    {
        return new Result<TValue, TError>.Success(value);
    }

    public static Failure Fail(TError error)
    {
        return new Result<TValue, TError>.Failure(error);
    }

    public TValue PromiseSuccess()
    {
        return this switch
        {
            Success success => success.Value,
            Failure failure => throw new InvalidOperationException(
                $"Cannot get Success value (TValue) from a Failure. TError: {failure.Error}"
            ),
            _ => throw new InvalidOperationException("Unknown Result state"),
        };
    }

    public TError PromiseFailure()
    {
        return this switch
        {
            Success success => throw new InvalidOperationException(
                $"Cannot get Failure value (TError) from a Success. TSuccess: {success.Value}"
            ),

            Failure failure => failure.Error,
            _ => throw new ArgumentOutOfRangeException(nameof(Result<TValue, TError>), this, null),
        };
    }

    public bool IsSuccess()
    {
        return this is Success;
    }

    public bool IsFailure()
    {
        return this is Failure;
    }

    public Result<TFinal, TError> Bind<TFinal>(Func<TValue, Result<TFinal, TError>> func)
    {
        return this is Success
            ? func(this.PromiseSuccess())
            : Result<TFinal, TError>.Fail(this.PromiseFailure());
    }
}
