using System;
using System.IO;
using System.Linq;

class Result
{
    public static int stringConstruction(string s)
    {
        return s.Distinct().Count();
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        for (int nItr = 0; nItr < n; nItr++)
        {
            string s = Console.ReadLine();

            int result = Result.stringConstruction(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
