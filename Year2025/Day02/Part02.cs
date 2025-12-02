namespace CSharpAoc.Year2025.Day02;

public class Part02
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
                for (int i = 1; i <= mid; i++)
                {
                    string chunk = idStr.Substring(0, i);
                    if (idStr.Replace(chunk, "").Length == 0)
                    {
                        total += id;
                        break;
                    }
                }
            }
        }
        return total;
    }
}
