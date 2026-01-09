namespace CSharpAoc.Year2015.Day02;

public class GetInput
{
    public static Giftbox[] Run()
    {
        return File.ReadAllLines("Year2015/Day02/input.txt")
            .Select(dimensionsString =>
            {
                var parts = dimensionsString.Split('x');
                int height = int.Parse(parts[0]);
                int width = int.Parse(parts[1]);
                int length = int.Parse(parts[2]);
                return new Giftbox(height, width, length);
            })
            .ToArray();
    }
}
