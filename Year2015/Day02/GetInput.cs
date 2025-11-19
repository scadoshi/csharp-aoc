namespace CSharpAoc.Year2015.Day02;

public class GetInput
{
    public static List<Giftbox> Run()
    {
        List<Giftbox> giftboxes = new();
        string[] giftboxesStr = File.ReadAllLines("Year2015/Day02/input.txt");
        foreach (string line in giftboxesStr)
        {
            string[] parts = line.Split("x");
            int height = int.Parse(parts[0]);
            int width = int.Parse(parts[1]);
            int length = int.Parse(parts[2]);
            Giftbox newGiftbox = new Giftbox(height, width, length);
            giftboxes.Add(newGiftbox);
        }
        return giftboxes;
    }
}