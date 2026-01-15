namespace CSharpAoc.Year2018.Day02;

public class Part01
{
    public static string? Run(string[] input)
    {
        (int pairs, int triples) = input.Aggregate(
            (Pairs: 0, Triples: 0),
            (acc, line) =>
            {
                var charCounts = line.GroupBy(c => c).Select(g => g.Count()).ToArray();
                return (
                    acc.Pairs + (charCounts.Contains(2) ? 1 : 0),
                    acc.Triples + (charCounts.Contains(3) ? 1 : 0)
                );
            }
        );
        return (pairs * triples).ToString();
    }
}
