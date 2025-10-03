using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static string HappyLadybugs(string b)
    {
        Dictionary<char, int> freq = new Dictionary<char, int>();
        bool hasEmptyCell = false;
        
        foreach (char c in b)
        {
            if (c == '_')
            {
                hasEmptyCell = true;
            }
            else
            {
                if (freq.ContainsKey(c))
                    freq[c]++;
                else
                    freq[c] = 1;
            }
        }
        
        if (freq.Count == 0)
            return "YES";
        
        if (hasEmptyCell)
        {
            foreach (var count in freq.Values)
            {
                if (count == 1)
                    return "NO";
            }
            return "YES";
        }
        else
        {
            for (int i = 0; i < b.Length; i++)
            {
                char current = b[i];
                bool hasSameAdjacent = false;
                
                if (i > 0 && b[i - 1] == current)
                    hasSameAdjacent = true;
                
                if (i < b.Length - 1 && b[i + 1] == current)
                    hasSameAdjacent = true;
                
                if (!hasSameAdjacent)
                    return "NO";
            }
            return "YES";
        }
    }
    
    static void Main(string[] args)
    {
        int g = Convert.ToInt32(Console.ReadLine().Trim());
        
        for (int i = 0; i < g; i++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            
            string b = Console.ReadLine();
            
            string result = HappyLadybugs(b);
            
            Console.WriteLine(result);
        }
    }
}
