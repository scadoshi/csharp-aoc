namespace CSharpAoc.Common.Direction;

using CSharpAoc.Common.Result;

public class Turn
{
    public enum Direction
    {
        Left,
        Right,
    }

    public Direction Dir;

    public static Result<Direction, string> TryParse(Face.Direction value)
    {
        return value switch
        {
            Face.Direction.Left => Result<Direction, string>.Succ(Direction.Left),
            Face.Direction.Right => Result<Direction, string>.Succ(Direction.Right),
            _ => Result<Direction, string>.Fail($"{value} is not a valid Direction"),
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

    public static Result<Direction, string> TryParse(string value)
    {
        return value.ToLower() switch
        {
            "up" or "u" => Result<Direction, string>.Succ(Direction.Up),
            "right" or "r" => Result<Direction, string>.Succ(Direction.Right),
            "down" or "d" => Result<Direction, string>.Succ(Direction.Down),
            "left" or "l" => Result<Direction, string>.Succ(Direction.Left),
            _ => Result<Direction, string>.Fail($"{value} is not a valid Direction"),
        };
    }

    public static Result<Direction, string> TryParse(char value)
    {
        return value switch
        {
            'u' or 'U' => Result<Direction, string>.Succ(Direction.Up),
            'r' or 'R' => Result<Direction, string>.Succ(Direction.Right),
            'd' or 'D' => Result<Direction, string>.Succ(Direction.Down),
            'l' or 'L' => Result<Direction, string>.Succ(Direction.Left),
            _ => Result<Direction, string>.Fail($"{value} is not a valid Direction"),
        };
    }

    public Direction Turn(Direction turn)
    {
        return turn switch
        {
            Direction.Right => this.Dir switch
            {
                Direction.Up => Direction.Right,
                Direction.Right => Direction.Down,
                Direction.Down => Direction.Left,
                Direction.Left => Direction.Up,
                _ => throw new ArgumentOutOfRangeException(nameof(this.Dir), this.Dir, null),
            },

            Direction.Left => this.Dir switch
            {
                Direction.Up => Direction.Left,
                Direction.Right => Direction.Up,
                Direction.Down => Direction.Right,
                Direction.Left => Direction.Down,
                _ => throw new ArgumentOutOfRangeException(nameof(this.Dir), this.Dir, null),
            },

            _ => throw new ArgumentOutOfRangeException(nameof(turn), turn, null),
        };
    }
}
