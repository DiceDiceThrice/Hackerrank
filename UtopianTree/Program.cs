using System;
using System.Collections.Generic;

class Solution
{
    static int UtopianTree(int n)
    {
        int height = 1;
        
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 1)
            {
                height *= 2;
            }
            else
            {
                height += 1;
            }
        }
        
        return height;
    }
    
    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());
        
        for (int i = 0; i < t; i++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            
            int result = UtopianTree(n);
            
            Console.WriteLine(result);
        }
    }
}
