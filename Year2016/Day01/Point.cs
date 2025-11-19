namespace CSharpAoc.Year2016.Day01;

public class Point
{
    public int x;
    public int y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public static Point Origin()
    {
        return new Point(0, 0);
    }

    public Point Clone()
    {
        return new Point(this.x, this.y);
    }

    public int DistanceFromOrigin()
    {
        return Math.Abs(this.x) + Math.Abs(this.y);
    }

    public override bool Equals(object? obj)
    {
        return obj is Point other && this.x == other.x && this.y == other.y;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(x, y);
    }
}

public class DirectionalPoint
{
    public Point point;
    public Facing facing;

    public DirectionalPoint(Point point, Facing facing)
    {
        this.point = point;
        this.facing = facing;
    }

    public static DirectionalPoint Start()
    {
        return new DirectionalPoint(Point.Origin(), Facing.Up());
    }

    public void Turn(Turning.Direction turningDirection)
    {
        this.facing.Turn(turningDirection);
    }

    public void Travel(int distance)
    {
        switch (this.facing.facingDirection)
        {
            case Facing.Direction.Up:
                this.point.y += distance;
                break;
            case Facing.Direction.Right:
                this.point.x += distance;
                break;
            case Facing.Direction.Down:
                this.point.y -= distance;
                break;
            case Facing.Direction.Left:
                this.point.x -= distance;
                break;
        }
    }

    public void Step()
    {
        this.Travel(1);
    }
}