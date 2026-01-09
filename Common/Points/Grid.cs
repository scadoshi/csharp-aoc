namespace CSharpAoc.Common;

public class GridPoint
{
    public int Row { get; set; }
    public int Col { get; set; }

    public GridPoint(int row, int col)
    {
        Row = row;
        Col = col;
    }

    public GridPoint Origin()
    {
        return new GridPoint(0, 0);
    }

    public GridPoint Clone()
    {
        return new GridPoint(this.Row, this.Col);
    }

    public GridPoint Moved(Face face, int distance)
    {
        return face.Dir switch
        {
            Face.Direction.Up => new GridPoint(Math.Max(0, this.Row - 1), this.Col),
            Face.Direction.Right => new GridPoint(this.Row, this.Col + 1),
            Face.Direction.Down => new GridPoint(this.Row + 1, this.Col),
            Face.Direction.Left => new GridPoint(this.Row, Math.Max(0, this.Col - 1)),
            _ => throw new ArgumentOutOfRangeException(nameof(face.Dir), face.Dir, null),
        };
    }

    public override bool Equals(object? obj)
    {
        return obj is GridPoint other && this.Row == other.Row && this.Col == other.Col;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Row, Col);
    }
}
