namespace CSharpAoc.Year2024.Day01;

public class Part02
{
    public static int Run((List<int>, List<int>) input)
    {
        int t = 0;
        Dictionary<int, int> dict1 = new();
        Dictionary<int, int> dict2 = new();
        (List<int> list1, List<int> list2) = input;
        int p = 0;
        do
        {
            if (!dict1.ContainsKey(list1[p]))
            {
                dict1[list1[p]] = 1;
            }
            else
            {
                dict1[list1[p]]++;
            }

            if (!dict2.ContainsKey(list2[p]))
            {
                dict2[list2[p]] = 1;
            }
            else
            {
                dict2[list2[p]]++;
            }
            p++;
        } while (p < list1.Count);

        foreach ((int k, int v1) in dict1)
        {
            int v2 = 0;
            if (dict2.ContainsKey(k))
            {
                v2 = dict2[k];
            }
            t += k * v1 * v2;
        }
        return t;
    }
}