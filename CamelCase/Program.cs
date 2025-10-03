using System;
using System.IO;

class Result
{
    public static int camelcase(string s)
    {
        if (string.IsNullOrEmpty(s))
            return 0;
        
        int wordCount = 1;
        
        foreach (char c in s)
        {
            if (char.IsUpper(c))
            {
                wordCount++;
            }
        }
        
        return wordCount;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        int result = Result.camelcase(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
