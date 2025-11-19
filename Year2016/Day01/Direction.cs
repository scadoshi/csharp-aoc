namespace CSharpAoc.Year2016.Day01;
public class Turning
{
    public enum Direction
    {
        Left, Right
    }
    public static Direction Parse(char value)
    {
        switch (char.ToLower(value))
        {
            case 'l':
                {
                    return Direction.Left;
                }
            case 'r':
                {
                    return Direction.Right;
                }
            case var x:
                {
                    throw new Exception($"invalid turning direction '{x}'");
                }
        }
    }
}

public class Facing
{
    public enum Direction
    {
        Left, Right, Up, Down
    }
    public Direction facingDirection;

    public Facing(Direction facingDirection)
    {
        this.facingDirection = facingDirection;
    }

    public static Facing Up()
    {
        return new Facing(Direction.Up);
    }

    public void Turn(Turning.Direction turningDirection)
    {
        if (turningDirection == Turning.Direction.Left)
        {
            switch (this.facingDirection)
            {
                case Direction.Up:
                    this.facingDirection = Direction.Left;
                    break;
                case Direction.Left:
                    this.facingDirection = Direction.Down;
                    break;
                case Direction.Down:
                    this.facingDirection = Direction.Right;
                    break;
                case Direction.Right:
                    this.facingDirection = Direction.Up;
                    break;
            }
        }
        else if (turningDirection == Turning.Direction.Right)
        {
            switch (this.facingDirection)
            {
                case Direction.Up:
                    this.facingDirection = Direction.Right;
                    break;
                case Direction.Right:
                    this.facingDirection = Direction.Down;
                    break;
                case Direction.Down:
                    this.facingDirection = Direction.Left;
                    break;
                case Direction.Left:
                    this.facingDirection = Direction.Up;
                    break;
            }
        }
        else
        {
            throw new Exception($"invalid turning direction '{turningDirection}'");
        }
    }
}


