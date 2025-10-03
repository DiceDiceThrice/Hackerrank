using System;
using System.Collections.Generic;

class Solution
{
    static List<string> CavityMap(List<string> grid)
    {
        int n = grid.Count;
        
        char[][] result = new char[n][];
        for (int i = 0; i < n; i++)
        {
            result[i] = grid[i].ToCharArray();
        }
        
        for (int i = 1; i < n - 1; i++)
        {
            for (int j = 1; j < n - 1; j++)
            {
                char current = grid[i][j];
                
                if (current > grid[i-1][j] &&  
                    current > grid[i+1][j] &&  
                    current > grid[i][j-1] && 
                    current > grid[i][j+1]) 
                {
                    result[i][j] = 'X';
                }
            }
        }
        
        List<string> output = new List<string>();
        for (int i = 0; i < n; i++)
        {
            output.Add(new string(result[i]));
        }
        
        return output;
    }
    
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        
        List<string> grid = new List<string>();
        for (int i = 0; i < n; i++)
        {
            grid.Add(Console.ReadLine());
        }
        
        List<string> result = CavityMap(grid);
        
        foreach (string row in result)
        {
            Console.WriteLine(row);
        }
    }
}
