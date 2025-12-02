namespace CSharpAoc.Year2025.Day02;

public class GetInput
{
    public static List<(long, long)> Run()
    {
        List<(long, long)> ranges = new();
        string input = File.ReadAllText("Year2025/Day02/input.txt");
        foreach (string s in input.Split(","))
        {
            string[] parts = s.Split("-");
            long start = long.Parse(parts[0]);
            long end = long.Parse(parts[1]);
            ranges.Add((start, end));
        }
        return ranges;
    }
}
