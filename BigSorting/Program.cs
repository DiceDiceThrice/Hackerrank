using System;
using System.Collections.Generic;
using System.IO;

class Result
{
    public static List<string> bigSorting(List<string> unsorted)
    {
        unsorted.Sort(new NumericStringComparer());
        return unsorted;
    }
    
    private class NumericStringComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            if (x.Length != y.Length)
            {
                return x.Length.CompareTo(y.Length);
            }
            
            for (int i = 0; i < x.Length; i++)
            {
                char charX = x[i];
                char charY = y[i];
                
                if (charX != charY)
                {
                    return charX.CompareTo(charY);
                }
            }
            
            return 0;
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> unsorted = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string unsortedItem = Console.ReadLine();
            unsorted.Add(unsortedItem);
        }

        List<string> result = Result.bigSorting(unsorted);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
