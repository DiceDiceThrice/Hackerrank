using System;
using System.IO;
using System.Linq;

class Result
{
    public static string funnyString(string s)
    {
        char[] chars = s.ToCharArray();
        char[] reversed = s.ToCharArray();
        Array.Reverse(reversed);
        
        for (int i = 1; i < chars.Length; i++)
        {
            int diff1 = Math.Abs(chars[i] - chars[i - 1]);
            int diff2 = Math.Abs(reversed[i] - reversed[i - 1]);
            
            if (diff1 != diff2)
            {
                return "Not Funny";
            }
        }
        
        return "Funny";
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

            string result = Result.funnyString(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
