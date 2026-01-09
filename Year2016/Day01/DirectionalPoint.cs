namespace CSharpAoc.Year2016.Day01;

using CSharpAoc.Common;

public class DirectionalPoint
{
    public Face Face { get; set; }
    public CartesianPoint Point { get; set; }

    public DirectionalPoint(Face face, CartesianPoint point)
    {
        Face = face;
        Point = point;
    }

    public static DirectionalPoint Start()
    {
        return new DirectionalPoint(new Face(Face.Direction.Up), CartesianPoint.Origin());
    }

    public void Rotate(Turn turn)
    {
        this.Face = this.Face.Rotated(turn.Dir);
    }

    public void Move(int distance)
    {
        this.Point = this.Point.Moved(this.Face, distance);
    }
}
