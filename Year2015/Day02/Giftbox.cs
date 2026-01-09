namespace CSharpAoc.Year2015.Day02;

public class Giftbox
{
    readonly int Height;
    readonly int Width;
    readonly int Length;

    public Giftbox(int height, int width, int length)
    {
        Height = height;
        Width = width;
        Length = length;
    }

    public int WrappingPaperRequired()
    {
        int frontBack = this.Height * this.Width;
        int leftRight = this.Height * this.Length;
        int topBottom = this.Width * this.Length;
        int smallest = Math.Min(topBottom, Math.Min(frontBack, leftRight));
        return frontBack * 2 + leftRight * 2 + topBottom * 2 + smallest;
    }

    public int Volume()
    {
        return this.Height * this.Width * this.Length;
    }

    public int RibbonRequired()
    {
        List<int> sides = [this.Height, this.Width, this.Length];
        sides.Sort();
        return sides[0] * 2 + sides[1] * 2 + this.Volume();
    }
}
