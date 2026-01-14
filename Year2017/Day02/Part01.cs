namespace CSharpAoc.Year2017.Day02;

public class Part01
{
    public static int Run(int[][] input)
    {
        return input.Select(nums => nums.Max() - nums.Min()).Sum();
    }
}
