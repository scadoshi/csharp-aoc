namespace CSharpAoc.Year2017.Day01;

public class GetInput
{
    public static List<int> Run()
    {
        string input = File.ReadAllText("Year2017/Day01/input.txt");
        List<int> output = new();
        foreach (char c in input)
        {
            output.Add(int.Parse(c.ToString()));
        }
        return output;
    }
}