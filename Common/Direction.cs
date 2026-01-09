namespace CSharpAoc.Common;

public class Turn
{
    public enum Direction
    {
        Left,
        Right,
    }

    public Direction Dir { get; set; }

    public Turn(Turn.Direction dir)
    {
        Dir = dir;
    }

    public static Turn Left()
    {
        return new Turn(Turn.Direction.Left);
    }

    public static Turn Right()
    {
        return new Turn(Turn.Direction.Right);
    }

    public static Result<Turn, string> TryParse(Face.Direction value)
    {
        return value switch
        {
            Face.Direction.Left => Result<Turn, string>.Succ(Turn.Left()),
            Face.Direction.Right => Result<Turn, string>.Succ(Turn.Right()),
            _ => Result<Turn, string>.Fail($"{value} is not a valid Direction"),
        };
    }

    public static Result<Turn, string> TryParse(string value)
    {
        return value.ToLower() switch
        {
            "left" or "l" => Result<Turn, string>.Succ(Turn.Left()),
            "right" or "r" => Result<Turn, string>.Succ(Turn.Right()),
            _ => Result<Turn, string>.Fail($"{value} is not a valid Direction"),
        };
    }

    public static Result<Turn, string> TryParse(char value)
    {
        return value switch
        {
            'l' or 'L' => Result<Turn, string>.Succ(Turn.Left()),
            'r' or 'R' => Result<Turn, string>.Succ(Turn.Right()),
            _ => Result<Turn, string>.Fail($"{value} is not a valid Direction"),
        };
    }
}

public class Face
{
    public enum Direction
    {
        Up,
        Right,
        Down,
        Left,
    }

    public Direction Dir { get; set; }

    public Face(Direction dir)
    {
        Dir = dir;
    }

    public static Face Up()
    {
        return new Face(Direction.Up);
    }

    public static Face Right()
    {
        return new Face(Direction.Right);
    }

    public static Face Down()
    {
        return new Face(Direction.Down);
    }

    public static Face Left()
    {
        return new Face(Direction.Left);
    }

    public static Result<Face, string> TryParse(string value)
    {
        return value.ToLower() switch
        {
            "up" or "u" => Result<Face, string>.Succ(Face.Up()),
            "right" or "r" => Result<Face, string>.Succ(Face.Right()),
            "down" or "d" => Result<Face, string>.Succ(Face.Down()),
            "left" or "l" => Result<Face, string>.Succ(Face.Left()),
            _ => Result<Face, string>.Fail($"{value} is not a valid Face.Direction"),
        };
    }

    public static Result<Face, string> TryParse(char value)
    {
        return value switch
        {
            'u' or 'U' => Result<Face, string>.Succ(Face.Up()),
            'r' or 'R' => Result<Face, string>.Succ(Face.Right()),
            'd' or 'D' => Result<Face, string>.Succ(Face.Down()),
            'l' or 'L' => Result<Face, string>.Succ(Face.Left()),
            _ => Result<Face, string>.Fail($"{value} is not a valid Direction"),
        };
    }

    public Face Rotated(Turn.Direction turn)
    {
        return turn switch
        {
            Turn.Direction.Right => this.Dir switch
            {
                Direction.Up => new Face(Direction.Right),
                Direction.Right => new Face(Direction.Down),
                Direction.Down => new Face(Direction.Left),
                Direction.Left => new Face(Direction.Up),
                _ => throw new ArgumentOutOfRangeException(nameof(this.Dir), this.Dir, null),
            },

            Turn.Direction.Left => this.Dir switch
            {
                Direction.Up => new Face(Direction.Left),
                Direction.Right => new Face(Direction.Up),
                Direction.Down => new Face(Direction.Right),
                Direction.Left => new Face(Direction.Down),
                _ => throw new ArgumentOutOfRangeException(nameof(this.Dir), this.Dir, null),
            },

            _ => throw new ArgumentOutOfRangeException(nameof(turn), turn, null),
        };
    }
}
