namespace CSharpAoc.Year2016.Day01;
public class Part02
{
    public static int? Run(List<Instruction> input)
    {
        DirectionalPoint directionalPoint = DirectionalPoint.Start();
        HashSet<Point> visited = new() { directionalPoint.point.Clone() };
        foreach (Instruction instruction in input)
        {
            directionalPoint.Turn(instruction.direction);
            foreach (int i in Enumerable.Range(0, instruction.distance))
            {
                directionalPoint.Step();
                if (visited.Contains(directionalPoint.point))
                {
                    return directionalPoint.point.DistanceFromOrigin();
                }
                else
                {
                    visited.Add(directionalPoint.point.Clone());
                }
            }

        }
        return null;
    }
}