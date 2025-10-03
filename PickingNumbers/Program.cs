using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static int PickingNumbers(List<int> a)
    {
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        
        foreach (int num in a)
        {
            if (frequency.ContainsKey(num))
                frequency[num]++;
            else
                frequency[num] = 1;
        }
        
        int maxLength = 0;
        
        foreach (int num in frequency.Keys)
        {
            maxLength = Math.Max(maxLength, frequency[num]);
            
            if (frequency.ContainsKey(num + 1))
            {
                maxLength = Math.Max(maxLength, frequency[num] + frequency[num + 1]);
            }
        }
        
        return maxLength;
    }
    
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        
        List<int> a = Console.ReadLine().TrimEnd()
                            .Split(' ')
                            .Select(aTemp => Convert.ToInt32(aTemp))
                            .ToList();
        
        int result = PickingNumbers(a);
        
        Console.WriteLine(result);
    }
}
