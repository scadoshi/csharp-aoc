namespace CSharpAoc.Year2016.Day01;

public class Part01
{
    public static int Run(Instruction[] input)
    {
        return input
            .Aggregate(
                DirectionalPoint.Start(),
                (directionalPoint, instruction) =>
                {
                    directionalPoint.Rotate(instruction.Turn);
                    directionalPoint.Move(instruction.Distance);
                    return directionalPoint;
                }
            )
            .Point.DistanceFromOrigin();
    }
}
