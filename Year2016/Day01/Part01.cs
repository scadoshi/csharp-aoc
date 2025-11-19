namespace CSharpAoc.Year2016.Day01;

public class Part01
{
    public static int Run(List<Instruction> input)
    {
        DirectionalPoint directionalPoint = DirectionalPoint.Start();
        foreach (Instruction instruction in input)
        {
            directionalPoint.Turn(instruction.direction);
            directionalPoint.Travel(instruction.distance);
        }
        return directionalPoint.point.DistanceFromOrigin();
    }
}