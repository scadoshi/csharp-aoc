namespace CSharpAoc.Year2021.Day01;
public class Part01
{
    public static int Run(List<int> input)
    {
        int total = 0;
        int p = 1;
        do
        {
            if (input[p] > input[p - 1])
            {
                total += 1;
            }
            p++;
        } while (p < input.Count);
        return total;
    }
}