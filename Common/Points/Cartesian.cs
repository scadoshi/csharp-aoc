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

    public static CartesianPoint Origin()
    {
        return new CartesianPoint(0, 0);
    }

    // public CartesianPoint Clone()
    // {
    //     return new CartesianPoint(this.X, this.Y);
    // }

    public int DistanceFromOrigin()
    {
        return Math.Abs(this.X) + Math.Abs(this.Y);
    }

    public CartesianPoint Moved(Face face, int distance)
    {
        return face.Dir switch
        {
            Face.Direction.Up => new CartesianPoint(this.X, this.Y + distance),
            Face.Direction.Right => new CartesianPoint(this.X + distance, this.Y),
            Face.Direction.Down => new CartesianPoint(this.X, this.Y - distance),
            Face.Direction.Left => new CartesianPoint(this.X - distance, this.Y),
            _ => throw new ArgumentOutOfRangeException(nameof(face.Dir), face.Dir, null),
        };
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
