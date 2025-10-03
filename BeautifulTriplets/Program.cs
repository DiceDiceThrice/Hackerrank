using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static int BeautifulTriplets(int d, List<int> arr)
    {
        Dictionary<int, int> freq = new Dictionary<int, int>();
        foreach (int num in arr)
        {
            if (freq.ContainsKey(num))
                freq[num]++;
            else
                freq[num] = 1;
        }
        
        int count = 0;
        
        foreach (int num in arr)
        {
            if (freq.ContainsKey(num - d) && freq.ContainsKey(num + d))
            {
                count += freq[num - d] * freq[num + d];
            }
        }
        
        return count;
    }
    
    static void Main(string[] args)
    {
        string[] firstLine = Console.ReadLine().TrimEnd().Split(' ');
        int n = Convert.ToInt32(firstLine[0]);
        int d = Convert.ToInt32(firstLine[1]);
        
        List<int> arr = Console.ReadLine().TrimEnd()
                            .Split(' ')
                            .Select(arrTemp => Convert.ToInt32(arrTemp))
                            .ToList();
        
        int result = BeautifulTriplets(d, arr);
        
        Console.WriteLine(result);
    }
}
