namespace CSharpAoc.Year2016.Day01;

using CSharpAoc.Common;

public class Instruction
{
    public readonly Turn Turn;
    public readonly int Distance;

    public Instruction(Turn turn, int distance)
    {
        Turn = turn;
        Distance = distance;
    }

    public static Result<Instruction, string> TryParse(string value)
    {
        // e.g. "L69"
        char[] chars = value.ToCharArray();
        if (chars.Length < 2)
        {
            return Result<Instruction, string>.Fail($"{value} is not a valid Instruction");
        }

        return Turn.TryParse(chars[0])
            .Bind(turn =>
                new string(chars[1..])
                    .TryParse()
                    .Bind(distance =>
                        Result<Instruction, string>.Succ(new Instruction(turn, distance))
                    )
            );
    }
}
