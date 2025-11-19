namespace CSharpAoc.Year2015.Day01;
public class Part02
{
    public static int Run(string input)
    {
        int f = 0;
        foreach (var (c, i) in input.Select((c, i) => (c, i)))
        {
            if (c == '(')
            {
                f++;
            }
            if (c == ')')
            {
                f--;
            }

            if (f < 0)
            {
                return i + 1;
            }
        }
        return -1;
    }
}