namespace CSharpAoc.Year2018.Day02;

public static class StringExtensions
{
    public static int differenceCount(this string thisString, string otherString)
    {
        return thisString.Zip(otherString).Where(chars => chars.First != chars.Second).Count();
    }

    public static (string, string)? findTwoStringsWithSingleCharDifference(this string[] input)
    {
        foreach (string str1 in input)
        {
            string? str2 = input.Where(str2 => str1.differenceCount(str2) == 1).FirstOrDefault();
            if (str2 == null)
            {
                continue;
            }
            return (str1, str2);
        }
        return null;
    }

    public static string? commonChars(this string thisString, string otherString)
    {
        return new string(
            thisString
                .Zip(otherString)
                .Where(chars => chars.First == chars.Second)
                .Select(chars => chars.First)
                .ToArray()
        );
    }
}

public class Part02
{
    public static string? Run(string[] input)
    {
        (string, string)? matchingStrings = input.findTwoStringsWithSingleCharDifference();
        if (!matchingStrings.HasValue)
            return null;
        var (str1, str2) = matchingStrings.Value;
        return str1.commonChars(str2);
    }
}
