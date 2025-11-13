namespace Aoc.Year2024.Day01;
using System;
public class Part01
{
    public static int Run((List<int>, List<int>) input)
    {
        (List<int> list1, List<int> list2) = input;
        int t = 0;
        int p = 0;
        do
        {
            t += Math.Abs(list1[p] - list2[p]);
            p++;
        } while (p < list1.Count());
        return t;
    }
}