using System;
using System.IO;

class Result
{
    public static int anagram(string s)
    {
        if (s.Length % 2 != 0)
            return -1;
        
        int n = s.Length;
        int mid = n / 2;
        
        int[] freq1 = new int[26];
        for (int i = 0; i < mid; i++)
        {
            freq1[s[i] - 'a']++;
        }
        
        int[] freq2 = new int[26];
        for (int i = mid; i < n; i++)
        {
            freq2[s[i] - 'a']++;
        }
        
        int changes = 0;
        for (int i = 0; i < 26; i++)
        {
            if (freq2[i] > freq1[i])
            {
                changes += freq2[i] - freq1[i];
            }
        }
        
        return changes;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            int result = Result.anagram(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
