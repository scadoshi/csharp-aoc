namespace CSharpAoc.Year2015.Day02;

public class Part02
{
    public static int Run(Giftbox[] input)
    {
        return input.Aggregate(
            0,
            (int total, Giftbox giftbox) => total += giftbox.RibbonRequired()
        );
    }
}
