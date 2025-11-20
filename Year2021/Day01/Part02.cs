namespace CSharpAoc.Year2021.Day01;
public class Part02
{
    public static int Run(List<int> input)
    {
        int total = 0;
        int p = 3;
        do
        {
            var current = input.GetRange(p - 2, 3).Sum();
            var last = input.GetRange(p - 3, 3).Sum();
            if (current > last)
            {
                total += 1;
            }
            p++;
        } while (p < input.Count);

        return total;
    }
}