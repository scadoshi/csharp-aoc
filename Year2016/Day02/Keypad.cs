namespace CSharpAoc.Year2016.Day02;

using CSharpAoc.Common;

public class Keypad
{
    public char?[,] Grid { get; set; }
    public GridPoint Finger { get; set; }

    public Keypad(char?[,] grid, GridPoint point)
    {
        Grid = grid;
        Finger = point;
    }

    public static Keypad Standard()
    {
        var grid = new char?[,]
        {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' },
        };
        var point = new GridPoint(1, 1);
        return new Keypad(grid, point);
    }

    public static Keypad Weird()
    {
        var grid = new char?[,]
        {
            { null, null, '1', null, null },
            { null, '2', '3', '4', null },
            { '5', '6', '7', '8', '9' },
            { null, 'A', 'B', 'C', null },
            { null, null, 'D', null, null },
        };
        var point = new GridPoint(0, 2);
        return new Keypad(grid, point);
    }

    public void MoveFinger(Face face, int distance)
    {
        var newPoint = this.Finger.Moved(face, distance);
        if (newPoint.Row >= this.Grid.GetLength(0))
        {
            return;
        }
        if (newPoint.Col >= this.Grid.GetLength(1))
        {
            return;
        }
        this.Finger = newPoint;
    }
}
