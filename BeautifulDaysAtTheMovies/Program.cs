using System;
using System.Linq;

class Solution
{
    static int BeautifulDays(int i, int j, int k)
    {
        int beautifulCount = 0;
        
        for (int day = i; day <= j; day++)
        {
            int reversed = ReverseNumber(day);
            
            int difference = Math.Abs(day - reversed);
            
            if (difference % k == 0)
            {
                beautifulCount++;
            }
        }
        
        return beautifulCount;
    }
    
    static int ReverseNumber(int num)
    {
        int reversed = 0;
        while (num > 0)
        {
            reversed = reversed * 10 + num % 10;
            num /= 10;
        }
        return reversed;
    }
    
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int i = Convert.ToInt32(input[0]);
        int j = Convert.ToInt32(input[1]);
        int k = Convert.ToInt32(input[2]);
        
        int result = BeautifulDays(i, j, k);
        
        Console.WriteLine(result);
    }
}
