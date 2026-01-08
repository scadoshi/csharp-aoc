namespace CSharpAoc.Common.Result;

public static class IntExtensions
{
    public static Result<int, string> TryParse(this string value)
    {
        return int.TryParse(value, out var num)
            ? Result<int, string>.Succ(num)
            : Result<int, string>.Fail($"{value} is not a valid int");
    }
}
