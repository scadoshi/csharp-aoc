
namespace CSharpAoc.Year2017.Day01;
public class Part02
{
    public static int Run(List<int> input)
    {
        int total = 0;
        int p = 0;
        do
        {
            int current = input[p];
            int next = input[(p + 2) % input.Count];
            if (current == next)
            {
                total += input[p];
            }
            p++;
        } while (p < input.Count);
        return total;
    }
}