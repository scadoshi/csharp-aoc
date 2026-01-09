namespace CSharpAoc.Year2016.Day01;

using CSharpAoc.Common;

public class Part01
{
    public static int Run(List<Instruction> input)
    {
        Directional directional = DirectionalPoint.Start();
        foreach (Instruction instruction in input)
        {
            directionalPoint.Turn(instruction.turn.Dir);
            directionalPoint.Travel(instruction.distance);
        }
        return directionalPoint.point.DistanceFromOrigin();
    }
}
