namespace CSharpAoc.Year2016.Day01;

using CSharpAoc.Common.Direction;

public class Instruction
{
    public readonly Turn.Direction turn;
    public readonly int distance;

    public Instruction(Turn.Direction turn, int distance)
    {
        this.turn = turn;
        this.distance = distance;
    }

    public static Instruction Parse(string value)
    {
        // e.g. "R5"
        char[] chars = value.ToCharArray();
        char directionChar = chars[0];
        var face = Face.TryParse(directionChar).GetOrThrow();
        var turn = Turn.TryParse(face).GetOrThrow();
        string distanceString = new string(chars[1..]);
        int distance = int.Parse(distanceString);
        return new Instruction(turn, distance);
    }
}
