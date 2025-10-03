using System;
using System.IO;

class Result
{
    public static int beautifulBinaryString(string b)
    {
        int changes = 0;
        int i = 0;
        
        while (i < b.Length - 2)
        {
            if (b[i] == '0' && b[i + 1] == '1' && b[i + 2] == '0')
            {
                changes++;
                i += 3;
            }
            else
            {
                i++;
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

        int n = Convert.ToInt32(Console.ReadLine().Trim());
        string b = Console.ReadLine();

        int result = Result.beautifulBinaryString(b);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
