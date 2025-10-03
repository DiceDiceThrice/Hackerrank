using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static int EqualizeArray(List<int> arr)
    {
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        
        foreach (int num in arr)
        {
            if (frequency.ContainsKey(num))
                frequency[num]++;
            else
                frequency[num] = 1;
        }
        
        int maxFrequency = frequency.Values.Max();
        
        return arr.Count - maxFrequency;
    }
    
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        
        List<int> arr = Console.ReadLine().TrimEnd()
                            .Split(' ')
                            .Select(arrTemp => Convert.ToInt32(arrTemp))
                            .ToList();
        
        int result = EqualizeArray(arr);
        
        Console.WriteLine(result);
    }
}
