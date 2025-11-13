namespace Aoc.Year2024.Day01;

public class GetInput
{
    public static (List<int>, List<int>) Run()
    {
        List<int> list1 = new();
        List<int> list2 = new();
        foreach (string line in File.ReadAllLines("Year2024/Day01/input.txt"))
        {
            string[] parts = line.Split(" ");
            list1.Add(int.Parse(parts[0]));
            list2.Add(int.Parse(parts[1]));
        }
        list1.Sort();
        list2.Sort();
        return (list1, list2);
    }
}