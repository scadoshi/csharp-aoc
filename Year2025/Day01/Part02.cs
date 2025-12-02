namespace CSharpAoc.Year2025.Day01;
public class Part02
{
    public static int Run(List<int> input)
    {
        int p = 50;
        int t = 0;
        foreach (int num in input)
        {
            foreach (var _ in Enumerable.Range(0, Math.Abs(num)))
            {
                p = (p + Math.Sign(num)) % 100;
                if (p < 0)
                {
                    p += 100;
                }
                if (p == 0)
                {
                    t++;
                }
            }
        }
        return t;
    }
}
