namespace CSharpAoc.Year20YY.Day01;
public class GetInput
{
    public static int Run()
    {
        string input = File.ReadAllText("Year20YY/DayDD/input.txt");
        return int.Parse(input);
    }
}
