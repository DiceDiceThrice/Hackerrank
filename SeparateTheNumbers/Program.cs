using System;
using System.IO;
using System.Numerics;

class Result
{
    public static void separateNumbers(string s)
    {
        for (int len = 1; len <= s.Length / 2; len++)
        {
            string firstStr = s.Substring(0, len);
            
            if (firstStr.Length > 1 && firstStr[0] == '0')
                continue;
                
            BigInteger current = BigInteger.Parse(firstStr);
            BigInteger next = current + 1;
            string currentStr = firstStr;
            string built = firstStr;
            
            while (built.Length < s.Length)
            {
                string nextStr = next.ToString();
                built += nextStr;
                current = next;
                next++;
            }
            
            if (built == s)
            {
                Console.WriteLine($"YES {firstStr}");
                return;
            }
        }
        
        Console.WriteLine("NO");
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            Result.separateNumbers(s);
        }
    }
}
