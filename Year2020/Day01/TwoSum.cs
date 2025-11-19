namespace CSharpAoc.Year2020.Day01;
public class NumSum
{
    public static int? TwoSum(List<int> nums, int target)
    {
        foreach (int num1 in nums)
        {
            int subTarget = target - num1;
            foreach (int num2 in nums)
            {
                if (num2 == subTarget)
                {
                    return num1 * num2;
                }
            }
        }
        return null;
    }

    public static int? ThreeSum(List<int> nums, int target)
    {
        foreach (int num1 in nums)
        {
            int subTarget = target - num1;
            foreach (int num2 in nums)
            {
                int? result = TwoSum(nums, subTarget);
                if (result != null)
                {
                    return result * num1;
                }
            }
        }
        return null;
    }
}