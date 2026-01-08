namespace CSharpAoc.Common.Point.GridPoint;

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

    public int DistanceFromOrigin()
    {
        return Math.Abs(this.Row) + Math.Abs(this.Col);
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
