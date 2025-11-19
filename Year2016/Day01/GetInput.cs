namespace CSharpAoc.Year2016.Day01;

public class GetInput
{
    public static List<Instruction> Run()
    {
        List<Instruction> instructions = new();
        string[] parts = File.ReadAllText("Year2016/Day01/input.txt").Split(",");
        foreach (string part in parts)
        {
            instructions.Add(Instruction.Parse(part.Trim()));
        }
        return instructions;
    }
}

