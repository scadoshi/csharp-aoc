namespace Common;

public enum TurnDirection
{
    Left,
    Right,
}

public static class TurnDirectionExtensions
{
    public static Result<TurnDirection, string> TryParse(Direction value)
    {
        return value switch
        {
            Direction.Left => Result<TurnDirection, string>.Succ(TurnDirection.Left),
            Direction.Right => Result<TurnDirection, string>.Succ(TurnDirection.Right),
            _ => Result<TurnDirection, string>.Fail($"{value} is not a valid TurnDirection"),
        };
    }
}

public enum Direction
{
    Up,
    Right,
    Down,
    Left,
}

public static class DirectionExtensions
{
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

    public static Direction Turn(this Direction direction, TurnDirection turn)
    {
        return turn switch
        {
            TurnDirection.Right => direction switch
            {
                Direction.Up => Direction.Right,
                Direction.Right => Direction.Down,
                Direction.Down => Direction.Left,
                Direction.Left => Direction.Up,
                _ => throw new ArgumentOutOfRangeException(nameof(direction), direction, null),
            },

            TurnDirection.Left => direction switch
            {
                Direction.Up => Direction.Left,
                Direction.Right => Direction.Up,
                Direction.Down => Direction.Right,
                Direction.Left => Direction.Down,
                _ => throw new ArgumentOutOfRangeException(nameof(direction), direction, null),
            },

            _ => throw new ArgumentOutOfRangeException(nameof(turn), turn, null),
        };
    }
}
