using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static List<int> CutTheSticks(List<int> arr)
    {
        List<int> result = new List<int>();
        
        arr.Sort();
        
        int n = arr.Count;
        int index = 0;
        
        while (index < n)
        {
            result.Add(n - index);
            
            int currentMin = arr[index];
            
            while (index < n && arr[index] == currentMin)
            {
                index++;
            }
            
        }
        
        return result;
    }
    
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        
        List<int> arr = Console.ReadLine().TrimEnd()
                            .Split(' ')
                            .Select(arrTemp => Convert.ToInt32(arrTemp))
                            .ToList();
        
        List<int> result = CutTheSticks(arr);
        
        foreach (int res in result)
        {
            Console.WriteLine(res);
        }
    }
}
