using System;
using System.IO;
using System.Linq;

class Result
{
    public static string gameOfThrones(string s)
    {
        int[] freq = new int[26];
        foreach (char c in s)
        {
            freq[c - 'a']++;
        }
        
        int oddCount = 0;
        foreach (int count in freq)
        {
            if (count % 2 != 0)
            {
                oddCount++;
            }
        }
        
        if (s.Length % 2 == 0)
        {
            return oddCount == 0 ? "YES" : "NO";
        }
        else
        {
            return oddCount == 1 ? "YES" : "NO";
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.gameOfThrones(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
