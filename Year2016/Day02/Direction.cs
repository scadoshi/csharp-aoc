namespace CSharpAoc.Year2016.Day02;

public enum Direction
{
    Up,
    Right,
    Down,
    Left,
}

public class DirectionExt {
    public static bool TryParse(string value, out Direction direction)
    {
        switch (value) 
        {
          case 'R': {
              return Direction.Right;
          }
          case 'L': {
              return Direction.Left;
          }
          case 'U': {
              return Direction.Up;
          }
          case 'D': {
              return Direction.Down;
          }
      default: {
          return 
      }
        }
    }
}
