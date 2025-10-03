using System;
using System.IO;
using System.Linq;

class Result
{
    public static string twoStrings(string s1, string s2)
    {
        var set1 = new HashSet<char>(s1);
        var set2 = new HashSet<char>(s2);
        
        if (set1.Overlaps(set2))
        {
            return "YES";
        }
        else
        {
            return "NO";
        }
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
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            string result = Result.twoStrings(s1, s2);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
