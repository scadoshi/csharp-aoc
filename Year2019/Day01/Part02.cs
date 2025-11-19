namespace CSharpAoc.Year2019.Day01;
public class Part02
{
    public static int Run(List<int> input)
    {
        Queue<int> queue = new Queue<int>(input);
        int total = 0;
        do
        {
            int current = queue.Dequeue();
            int fuel = Fuel.Required(current);
            if (fuel > 0)
            {
                total += fuel;
                queue.Enqueue(fuel);
            }
        } while (queue.Count > 0);
        return total;
    }
}