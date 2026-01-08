namespace CSharpAoc.Common;

public class CartesianPoint
{
    public int X { get; set; }
    public int Y { get; set; }

    public CartesianPoint(int x, int y)
    {
        X = x;
        Y = y;
    }

    public CartesianPoint Origin()
    {
        return new CartesianPoint(0, 0);
    }

    public CartesianPoint Clone()
    {
        return new CartesianPoint(this.X, this.Y);
    }

    public int DistanceFromOrigin()
    {
        return Math.Abs(this.X) + Math.Abs(this.Y);
    }

    public override bool Equals(object? obj)
    {
        return obj is CartesianPoint other && this.X == other.X && this.Y == other.Y;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }
}
