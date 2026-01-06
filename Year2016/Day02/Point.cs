namespace CSharpAoc.Year2016.Day02;

public class Point
{
    public int row;
    public int col;

    public Point(int row, int col)
    {
        this.row = row;
        this.col = col;
    }

    public void Move(Direction direction, int steps, Keypad keypad)
    {
        foreach (int step in Enumerable.Range(0, steps))
        {
            switch (direction)
            {
                case Direction.Up:
                {
                    var next = this.row - 1;
                    if (next < 0)
                    {
                        break;
                    }
                    this.row = next;
                    break;
                }
                case Direction.Right:
                {
                    var next = this.col + 1;
                    if (next > keypad.grid.GetLength(1) - 1)
                    {
                        break;
                    }
                    this.col = next;
                    break;
                }
                case Direction.Down:
                {
                    var next = this.row + 1;
                    if (next > keypad.grid.GetLength(0) - 1)
                    {
                        break;
                    }
                    this.row = next;
                    break;
                }
                case Direction.Left:
                {
                    var next = this.col - 1;
                    if (next < 0)
                    {
                        break;
                    }
                    this.col = next;
                    break;
                }
            }
        }
    }
}
