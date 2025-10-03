using System;
using System.Collections.Generic;

class Solution
{
    static int getTotalX(int[] a, int[] b)
    {
        int count = 0;

        int start = a[a.Length - 1];
        int end = b[0];
        
        for (int i = start; i <= end; i++)
        {
            bool isValid = true;
            
            foreach (int num in a)
            {
                if (i % num != 0)
                {
                    isValid = false;
                    break;
                }
            }
            
            if (isValid)
            {
                foreach (int num in b)
                {
                    if (num % i != 0)
                    {
                        isValid = false;
                        break;
                    }
                }
            }
            
            if (isValid)
            {
                count++;
            }
        }
        
        return count;
    }

    static void Main(string[] args)
    {
        string[] firstLine = Console.ReadLine().Split(' ');
        int n = int.Parse(firstLine[0]);
        int m = int.Parse(firstLine[1]);
        
        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        
        int result = getTotalX(a, b);
        Console.WriteLine(result);
    }
}
