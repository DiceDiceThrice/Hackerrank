using System;

class Solution
{
    static string AppendAndDelete(string s, string t, int k)
    {
        int commonLength = 0;
        int minLength = Math.Min(s.Length, t.Length);
        
        for (int i = 0; i < minLength; i++)
        {
            if (s[i] == t[i])
            {
                commonLength++;
            }
            else
            {
                break;
            }
        }
        
        int minOperations = (s.Length - commonLength) + (t.Length - commonLength);
        
        if (k >= minOperations && (k - minOperations) % 2 == 0)
        {
            return "Yes";
        }

        else if (k >= s.Length + t.Length)
        {
            return "Yes";
        }
        else
        {
            return "No";
        }
    }
    
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        string t = Console.ReadLine();
        int k = Convert.ToInt32(Console.ReadLine().Trim());
        
        string result = AppendAndDelete(s, t, k);
        
        Console.WriteLine(result);
    }
}
