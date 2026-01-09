namespace CSharpAoc.Year2016.Day01;

public class GetInput
{
    public static Instruction[] Run()
    {
        return File.ReadAllText("Year2016/Day01/input.txt")
            .Split(",")
            .Where(instructionString => instructionString.Trim() != "")
            .Select(instructionString =>
                Instruction.TryParse(instructionString.Trim()).PromiseSuccess()
            )
            .ToArray();
    }
}
