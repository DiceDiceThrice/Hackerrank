using System;
using System.IO;

class Result
{
    public static int makingAnagrams(string s1, string s2)
    {
        int[] freq1 = new int[26];
        int[] freq2 = new int[26];
        
        foreach (char c in s1)
        {
            freq1[c - 'a']++;
        }
        
        foreach (char c in s2)
        {
            freq2[c - 'a']++;
        }
        
        int deletions = 0;
        for (int i = 0; i < 26; i++)
        {
            deletions += Math.Abs(freq1[i] - freq2[i]);
        }
        
        return deletions;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();

        int result = Result.makingAnagrams(s1, s2);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
