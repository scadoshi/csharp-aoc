namespace CSharpAoc.Year2017.Day02;

public class Part02
{
    public static int Run(int[][] input)
    {
        return input
            .Select(nums =>
            {
                var enumerated = nums.Select((num1, i) => (i, num1));
                foreach ((int i, int num1) in enumerated)
                {
                    int num2 = nums.Where((num2, j) => num1 % num2 == 0 && i != j).FirstOrDefault();
                    if (num2 == 0)
                    {
                        continue;
                    }
                    return num1 / num2;
                }
                return 0;
            })
            .Sum();
    }
}
