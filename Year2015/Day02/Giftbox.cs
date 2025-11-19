namespace CSharpAoc.Year2015.Day02;

public class Giftbox
{
    readonly int height;
    readonly int width;
    readonly int length;

    public Giftbox(int h, int w, int l)
    {
        height = h;
        width = w;
        length = l;
    }

    public int WrappingPaperRequired()
    {
        int frontBack = this.height * this.width;
        int leftRight = this.height * this.length;
        int topBottom = this.width * this.length;
        int smallest = Math.Min(topBottom, Math.Min(frontBack, leftRight));
        return frontBack * 2 + leftRight * 2 + topBottom * 2 + smallest;
    }

    public int Volume()
    {
        return this.height * this.width * this.length;
    }

    public int RibbonRequired()
    {
        List<int> sides = [this.height, this.width, this.length];
        sides.Sort();
        return sides[0] * 2 + sides[1] * 2 + this.Volume();
    }
}