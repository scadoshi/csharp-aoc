namespace CSharpAoc.Year2015.Day02;

public class Part02
{
    public static int Run(List<Giftbox> input)
    {
        int total = 0;
        foreach (Giftbox giftbox in input)
        {
            total += giftbox.RibbonRequired();
        }
        return total;
    }
}