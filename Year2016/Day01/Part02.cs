namespace CSharpAoc.Year2016.Day01;

using CSharpAoc.Common;

public class Part02
{
    public static int? Run(Instruction[] input)
    {
        var directionalPoint = DirectionalPoint.Start();
        var visited = new HashSet<CartesianPoint>();
        visited.Add(directionalPoint.Point);

        foreach (var instruction in input)
        {
            directionalPoint.Rotate(instruction.Turn);
            for (int i = 1; i <= instruction.Distance; i++)
            {
                directionalPoint.Move(1);
                if (visited.Contains(directionalPoint.Point))
                {
                    return directionalPoint.Point.DistanceFromOrigin();
                }
                visited.Add(directionalPoint.Point);
            }
        }
        return null;
    }
}
