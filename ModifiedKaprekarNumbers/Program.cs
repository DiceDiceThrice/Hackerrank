using System;
using System.Collections.Generic;

class Solution
{
    static void KaprekarNumbers(int p, int q)
    {
        List<int> results = new List<int>();
        
        for (int n = p; n <= q; n++)
        {
            long square = (long)n * n;
            string squareStr = square.ToString();
            int d = n.ToString().Length;
            
            string rightStr = squareStr.Length >= d ? 
                            squareStr.Substring(squareStr.Length - d) : 
                            squareStr.PadLeft(d, '0');
            string leftStr = squareStr.Length > d ? 
                           squareStr.Substring(0, squareStr.Length - d) : "0";
            
            if (string.IsNullOrEmpty(leftStr))
            {
                leftStr = "0";
            }
            
            int left = int.Parse(leftStr);
            int right = int.Parse(rightStr);
            
            if (left + right == n)
            {
                results.Add(n);
            }
        }
        
        if (results.Count == 0)
        {
            Console.WriteLine("INVALID RANGE");
        }
        else
        {
            Console.WriteLine(string.Join(" ", results));
        }
    }
    
    static void Main(string[] args)
    {
        int p = Convert.ToInt32(Console.ReadLine().Trim());
        int q = Convert.ToInt32(Console.ReadLine().Trim());
        
        KaprekarNumbers(p, q);
    }
}
