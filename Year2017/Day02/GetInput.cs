namespace CSharpAoc.Year2017.Day02;

using CSharpAoc.Common;

public class GetInput
{
    public static int[][] Run()
    {
        return File.ReadAllLines("Year2017/Day02/input.txt")
            .Where(line => line.Trim() != "")
            .Select(line =>
                line.Split(null as char[], StringSplitOptions.RemoveEmptyEntries)
                    .Where(str => str.Trim() != "")
                    .Select(str => IntExtensions.TryParse(str.Trim()).PromiseSuccess())
                    .ToArray()
            )
            .ToArray();
    }
}
