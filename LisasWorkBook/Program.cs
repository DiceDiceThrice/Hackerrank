using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static int Workbook(int n, int k, List<int> arr)
    {
        int specialCount = 0;
        int currentPage = 1;
        
        for (int chapter = 0; chapter < n; chapter++)
        {
            int problemsInChapter = arr[chapter];
            
            for (int problem = 1; problem <= problemsInChapter; problem++)
            {
                if (problem == currentPage)
                {
                    specialCount++;
                }
                
                if (problem % k == 0 && problem < problemsInChapter)
                {
                    currentPage++;
                }
            }
            
            currentPage++;
        }
        
        return specialCount;
    }
    
    static void Main(string[] args)
    {
        string[] firstLine = Console.ReadLine().TrimEnd().Split(' ');
        int n = Convert.ToInt32(firstLine[0]);
        int k = Convert.ToInt32(firstLine[1]);
        
        List<int> arr = Console.ReadLine().TrimEnd()
                            .Split(' ')
                            .Select(arrTemp => Convert.ToInt32(arrTemp))
                            .ToList();
        
        int result = Workbook(n, k, arr);
        
        Console.WriteLine(result);
    }
}
