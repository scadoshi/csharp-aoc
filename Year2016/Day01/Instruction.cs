namespace CSharpAoc.Year2016.Day01;

using Common;

public class Instruction
{
    public readonly TurnDirection turn;
    public readonly int distance;

    public Instruction(TurnDirection turn, int distance)
    {
        this.turn = turn;
        this.distance = distance;
    }

    public static Instruction Parse(string value)
    {
        // e.g. "R5"
        char[] chars = value.ToCharArray();
        char directionChar = chars[0];
        var direction = Direction.TryParse(directionChar).GetOrThrow();
        var turnDirection = TurnDirection.TryParse(direction).GetOrThrow();
        string distanceString = new string(chars[1..]);
        int distance = int.Parse(distanceString);
        return new Instruction(turningDirection, distance);
    }
}

