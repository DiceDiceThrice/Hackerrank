using System;
using System.Collections.Generic;

class Solution
{
    static int[] countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
    {
        int appleCount = 0;
        int orangeCount = 0;
        
        // Count apples that fall on Sam's house
        foreach (int apple in apples)
        {
            int position = a + apple;
            if (position >= s && position <= t)
            {
                appleCount++;
            }
        }
        
        // Count oranges that fall on Sam's house
        foreach (int orange in oranges)
        {
            int position = b + orange;
            if (position >= s && position <= t)
            {
                orangeCount++;
            }
        }
        
        return new int[] { appleCount, orangeCount };
    }

    static void Main(string[] args)
    {
        string[] firstLine = Console.ReadLine().Split(' ');
        int s = int.Parse(firstLine[0]);
        int t = int.Parse(firstLine[1]);
        
        string[] secondLine = Console.ReadLine().Split(' ');
        int a = int.Parse(secondLine[0]);
        int b = int.Parse(secondLine[1]);
        
        string[] thirdLine = Console.ReadLine().Split(' ');
        int m = int.Parse(thirdLine[0]);
        int n = int.Parse(thirdLine[1]);
        
        int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        
        int[] result = countApplesAndOranges(s, t, a, b, apples, oranges);
        Console.WriteLine(result[0]);
        Console.WriteLine(result[1]);
    }
}
