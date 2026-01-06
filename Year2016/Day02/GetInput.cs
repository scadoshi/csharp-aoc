namespace CSharpAoc.Year2016.Day02;

public class GetInput
{
    public static int Run()
    {
        string input = File.ReadAllText("Year2016/Day02/input.txt");
        return int.Parse(input);
    }
}
