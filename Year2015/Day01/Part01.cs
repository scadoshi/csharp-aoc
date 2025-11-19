namespace CSharpAoc.Year2015.Day01;
public class Part01
{
    public static int Run(string input)
    {
        int f = 0;
        foreach (char c in input)
        {
            if (c == '(')
            {
                f++;
            }
            else if (c == ')')
            {
                f--;
            }
        }
        return f;
    }
}