namespace CSharpAoc.Year2016.Day02;

using CSharpAoc.Common;

public class GetInput
{
    public static Face[][] Run()
    {
        return File.ReadLines("Year2016/Day02/input.txt")
            .Where(line => line.Trim() != "")
            .Select(line =>
            {
                return line.Trim()
                    .AsEnumerable()
                    .Select(c => Face.TryParse(c).PromiseSuccess())
                    .ToArray();
            })
            .ToArray();
    }
}
