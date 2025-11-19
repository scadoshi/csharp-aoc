namespace CSharpAoc.Year2020.Day01;
public class Part02
{
    public static int? Run(List<int> input)
    {
        int target = 2020;
        return NumSum.ThreeSum(input, target);
    }
}