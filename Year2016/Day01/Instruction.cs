namespace CSharpAoc.Year2016.Day01;

public class Instruction
{
    public readonly Turning.Direction direction;
    public readonly int distance;

    public Instruction(Turning.Direction direction, int distance)
    {
        this.direction = direction;
        this.distance = distance;
    }

    public static Instruction Parse(string value)
    {
        // e.g. "R5"
        char[] chars = value.ToCharArray();
        char directionChar = chars[0];
        Turning.Direction turningDirection = Turning.Parse(directionChar);
        string distanceString = new string(chars[1..]);
        int distance = int.Parse(distanceString);
        return new Instruction(turningDirection, distance);
    }
}