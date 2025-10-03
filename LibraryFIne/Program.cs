using System;

class Solution
{
    static int LibraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
    {
        if (y1 > y2)
        {
            return 10000;
        }
        else if (y1 == y2 && m1 > m2)
        {
            return 500 * (m1 - m2);
        }
        else if (y1 == y2 && m1 == m2 && d1 > d2)
        {
            return 15 * (d1 - d2);
        }
        else
        {
            return 0;
        }
    }
    
    static void Main(string[] args)
    {
        string[] returnedDate = Console.ReadLine().TrimEnd().Split(' ');
        int d1 = Convert.ToInt32(returnedDate[0]);
        int m1 = Convert.ToInt32(returnedDate[1]);
        int y1 = Convert.ToInt32(returnedDate[2]);
        
        string[] dueDate = Console.ReadLine().TrimEnd().Split(' ');
        int d2 = Convert.ToInt32(dueDate[0]);
        int m2 = Convert.ToInt32(dueDate[1]);
        int y2 = Convert.ToInt32(dueDate[2]);
        
        int result = LibraryFine(d1, m1, y1, d2, m2, y2);
        
        Console.WriteLine(result);
    }
}
