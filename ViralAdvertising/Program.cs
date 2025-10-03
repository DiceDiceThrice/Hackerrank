using System;

class Solution
{
    static int ViralAdvertising(int n)
    {
        int shared = 5;
        int cumulativeLikes = 0;
        
        for (int day = 1; day <= n; day++)
        {
            int liked = shared / 2;
            cumulativeLikes += liked;
            shared = liked * 3;
        }
        
        return cumulativeLikes;
    }
    
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        
        int result = ViralAdvertising(n);
        
        Console.WriteLine(result);
    }
}
