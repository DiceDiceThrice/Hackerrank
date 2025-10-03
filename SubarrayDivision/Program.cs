using System;

class Solution
{
    static int birthday(int[] s, int d, int m)
    {
        int count = 0;
        
        for (int i = 0; i <= s.Length - m; i++)
        {
            int sum = 0;
            
            for (int j = i; j < i + m; j++)
            {
                sum += s[j];
            }
            
            if (sum == d)
            {
                count++;
            }
        }
        
        return count;
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] s = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        
        string[] lastLine = Console.ReadLine().Split(' ');
        int d = int.Parse(lastLine[0]);
        int m = int.Parse(lastLine[1]);
        
        int result = birthday(s, d, m);
        Console.WriteLine(result);
    }
}
