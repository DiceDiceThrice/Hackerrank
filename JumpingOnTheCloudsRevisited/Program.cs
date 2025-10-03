using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static int JumpingOnClouds(int[] c, int k)
    {
        int n = c.Length;
        int energy = 100;
        int position = 0;
        
        do
        {
            position = (position + k) % n;
            
            energy--;
            
            if (c[position] == 1)
            {
                energy -= 2;
            }
            
        } while (position != 0);
        
        return energy;
    }
    
    static void Main(string[] args)
    {
        string[] firstLine = Console.ReadLine().TrimEnd().Split(' ');
        int n = Convert.ToInt32(firstLine[0]);
        int k = Convert.ToInt32(firstLine[1]);
        
        int[] c = Console.ReadLine().TrimEnd()
                        .Split(' ')
                        .Select(cTemp => Convert.ToInt32(cTemp))
                        .ToArray();
        
        int result = JumpingOnClouds(c, k);
        
        Console.WriteLine(result);
    }
}
