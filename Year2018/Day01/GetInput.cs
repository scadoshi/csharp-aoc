namespace CSharpAoc.Year2018.Day01;
public class GetInput
{
    public static List<int> Run()
    {
        string[] input = File.ReadAllLines("Year2018/Day01/input.txt");
        List<int> output = new();
        foreach (string numStr in input)
        {
            output.Add(int.Parse(numStr));
        }
        return output;
    }
}