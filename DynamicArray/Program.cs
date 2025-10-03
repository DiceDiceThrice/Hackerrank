using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    public static List<int> dynamicArray(int n, List<List<int>> queries)
    {
        List<List<int>> arr = new List<List<int>>();
        List<int> answers = new List<int>();
        int lastAnswer = 0;
        
        for (int i = 0; i < n; i++)
        {
            arr.Add(new List<int>());
        }
        
        foreach (var query in queries)
        {
            int type = query[0];
            int x = query[1];
            int y = query[2];
            
            int idx = (x ^ lastAnswer) % n;
            
            if (type == 1)
            {
                arr[idx].Add(y);
            }
            else if (type == 2)
            {
                int size = arr[idx].Count;
                lastAnswer = arr[idx][y % size];
                answers.Add(lastAnswer);
            }
        }
        
        return answers;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);
        int q = Convert.ToInt32(firstMultipleInput[1]);

        List<List<int>> queries = new List<List<int>>();

        for (int i = 0; i < q; i++)
        {
            queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
        }

        List<int> result = Result.dynamicArray(n, queries);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}