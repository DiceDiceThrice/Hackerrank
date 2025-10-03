using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static int JumpingOnClouds(int[] c)
    {
        int jumps = 0;
        int position = 0;
        int n = c.Length;
        
        while (position < n - 1)
        {
            if (position + 2 < n && c[position + 2] == 0)
            {
                position += 2;
            }
            else
            {
                position += 1;
            }
            jumps++;
        }
        
        return jumps;
    }
    
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        
        int[] c = Console.ReadLine().TrimEnd()
                        .Split(' ')
                        .Select(cTemp => Convert.ToInt32(cTemp))
                        .ToArray();
        
        int result = JumpingOnClouds(c);
        
        Console.WriteLine(result);
    }
}
