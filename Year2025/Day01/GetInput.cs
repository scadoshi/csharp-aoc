namespace CSharpAoc.Year2025.Day01;
public class GetInput
{
    public static List<int> Run()
    {
        List<int> output = new();
        string[] input = File.ReadAllLines("Year2025/Day01/input.txt");
        foreach (string numStr in input)
        {
            output.Add(int.Parse(numStr.Replace( "L", "-").Replace("R", "")));
        }
        return output;
    }
}
