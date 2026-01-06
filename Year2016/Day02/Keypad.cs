namespace CSharpAoc.Year2016.Day02;

public class Keypad
{
    public char?[,] grid;

    public Keypad(char?[,] grid)
    {
        this.grid = grid;
    }

    public static Keypad Standard()
    {
        return new Keypad(
            new char?[,]
            {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' },
            }
        );
    }

    public Point Center()
    {
        return new Point(this.grid.GetLength(0) / 2 + 1, this.grid.GetLength(1) / 2 + 1);
    }
}
