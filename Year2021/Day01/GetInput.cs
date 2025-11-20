namespace CSharpAoc.Year2021.Day01;
public class GetInput
{
    public static List<int> Run()
    {
        string[] input = File.ReadAllLines("Year2021/Day01/input.txt");
        List<int> output = new();
        foreach (string s in input)
        {
            output.Add(int.Parse(s));
        }
        return output;
    }
}