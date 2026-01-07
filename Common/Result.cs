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

    public TValue GetOrThrow()
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
}
