using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        
        for (int i = 1; i < n; i++)
        {
            int current = arr[i];
            int j = i - 1;
            
            while (j >= 0 && arr[j] > current)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = current;
        }
        
        Console.WriteLine(string.Join(" ", arr));
    }
}
