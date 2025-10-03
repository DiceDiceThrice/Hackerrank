using System;
using System.Linq;

class Solution
{
    static long RepeatedString(string s, long n)
    {
        long countInOne = s.Count(c => c == 'a');
        
        long completeRepetitions = n / s.Length;
        
        long remainingChars = n % s.Length;
        
        long totalCount = completeRepetitions * countInOne;
        
        for (int i = 0; i < remainingChars; i++)
        {
            if (s[i] == 'a')
            {
                totalCount++;
            }
        }
        
        return totalCount;
    }
    
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        
        long n = Convert.ToInt64(Console.ReadLine().Trim());
        
        long result = RepeatedString(s, n);
        
        Console.WriteLine(result);
    }
}
