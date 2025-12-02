namespace CSharpAoc.Year2025.Day02;

public class Part01
{
    public static long Run(List<(long, long)> input)
    {
        long total = 0;
        foreach ((long start, long end) in input)
        {
            for (long id = start; id <= end; id++)
            {
                string idStr = id.ToString();
                int mid = idStr.Length / 2;
                string first = idStr.Substring(0, mid);
                string second = idStr.Substring(mid);
                if (first == second)
                {
                    total += id;
                }
            }
        }
        return total;
    }
}
