using System;

class Solution
{
    static long StrangeCounter(long t)
    {
        long cycleStartTime = 1;
        long cycleValue = 3;
        
        while (cycleStartTime + cycleValue - 1 < t)
        {
            cycleStartTime += cycleValue;
            cycleValue *= 2;
        }
        
        return cycleValue - (t - cycleStartTime);
    }
    
    static void Main(string[] args)
    {
        long t = Convert.ToInt64(Console.ReadLine().Trim());
        
        long result = StrangeCounter(t);
        
        Console.WriteLine(result);
    }
}
