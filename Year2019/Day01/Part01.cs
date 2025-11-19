namespace CSharpAoc.Year2019.Day01;
public class Part01
{
    public static int Run(List<int> input)
    {
        int total = 0;
        foreach (int n in input)
        {
            total += Fuel.Required(n);
        }
        return total;
    }
}