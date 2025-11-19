namespace CSharpAoc.Year2015.Day02;
public class Part01
{
    public static int Run(List<Giftbox> input)
    {
        int total = 0;
        foreach (Giftbox giftbox in input)
        {
            total += giftbox.WrappingPaperRequired();
        }
        return total;
    }
}