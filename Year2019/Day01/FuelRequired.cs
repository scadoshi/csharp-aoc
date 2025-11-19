namespace CSharpAoc.Year2019.Day01;
public class Fuel
{
    public static int Required(int weight)
    {
        int calculated = (weight / 3) - 2;
        if (calculated < 0)
        {
            return 0;
        }
        return calculated;
    }
}