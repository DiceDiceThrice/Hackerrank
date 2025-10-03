using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static string AngryProfessor(int k, List<int> a)
    {
        int onTimeCount = 0;
        
        foreach (int arrivalTime in a)
        {
            if (arrivalTime <= 0)
            {
                onTimeCount++;
            }
        }
        
        if (onTimeCount < k)
        {
            return "YES";
        }
        else
        {
            return "NO";
        }
    }
    
    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());
        
        for (int i = 0; i < t; i++)
        {
            string[] nk = Console.ReadLine().TrimEnd().Split(' ');
            int n = Convert.ToInt32(nk[0]);
            int k = Convert.ToInt32(nk[1]);
            
            List<int> a = Console.ReadLine().TrimEnd()
                                .Split(' ')
                                .Select(aTemp => Convert.ToInt32(aTemp))
                                .ToList();
            
            string result = AngryProfessor(k, a);
            
            Console.WriteLine(result);
        }
    }
}
