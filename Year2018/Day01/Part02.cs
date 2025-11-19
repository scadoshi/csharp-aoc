namespace CSharpAoc.Year2018.Day01;
public class Part02
{
    public static int Run(List<int> input)
    {
        int frequency = 0;
        HashSet<int> seen = new() { frequency };
        while (true)
        {
            foreach (int n in input)
            {
                frequency += n;
                if (!seen.Add(frequency))
                {
                    return frequency;
                }
            }
        }
    }
}