using System;

class Solution
{
    static int HowManyGames(int p, int d, int m, int s)
    {
        int gamesBought = 0;
        int currentPrice = p;
        
        while (s >= currentPrice)
        {
            gamesBought++;
            s -= currentPrice;
            
            currentPrice = Math.Max(m, currentPrice - d);
        }
        
        return gamesBought;
    }
    
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int p = Convert.ToInt32(input[0]);
        int d = Convert.ToInt32(input[1]);
        int m = Convert.ToInt32(input[2]);
        int s = Convert.ToInt32(input[3]);
        
        int result = HowManyGames(p, d, m, s);
        
        Console.WriteLine(result);
    }
}
