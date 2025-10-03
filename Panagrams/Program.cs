using System;
using System.IO;
using System.Linq;

class Result
{
    public static string pangrams(string s)
    {
        var letters = s.ToLower().Where(char.IsLetter).ToHashSet();
        return letters.Count == 26 ? "pangram" : "not pangram";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.pangrams(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
