using System;

class Solution
{
    static long TaumBday(long b, long w, long bc, long wc, long z)
    {
        long cost1 = b * bc + w * wc;
        long cost2 = b * bc + w * (bc + z);
        long cost3 = w * wc + b * (wc + z); 
        
        return Math.Min(cost1, Math.Min(cost2, cost3));
    }
    
    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());
        
        for (int i = 0; i < t; i++)
        {
            string[] firstLine = Console.ReadLine().TrimEnd().Split(' ');
            long b = Convert.ToInt64(firstLine[0]);
            long w = Convert.ToInt64(firstLine[1]);
            
            string[] secondLine = Console.ReadLine().TrimEnd().Split(' ');
            long bc = Convert.ToInt64(secondLine[0]);
            long wc = Convert.ToInt64(secondLine[1]);
            long z = Convert.ToInt64(secondLine[2]);
            
            long result = TaumBday(b, w, bc, wc, z);
            
            Console.WriteLine(result);
        }
    }
}
