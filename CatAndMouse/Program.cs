using System;

class Solution
{
    static string CatAndMouse(int x, int y, int z)
    {
        int distA = Math.Abs(x - z);
        int distB = Math.Abs(y - z);

        if (distA < distB)
            return "Cat A";
        else if (distB < distA)
            return "Cat B";
        else
            return "Mouse C";
    }

    static void Main(string[] args)
    {
        int q = int.Parse(Console.ReadLine()); 
        for (int i = 0; i < q; i++)
        {
            string[] values = Console.ReadLine().Split(' ');
            int x = int.Parse(values[0]);
            int y = int.Parse(values[1]);
            int z = int.Parse(values[2]);

            Console.WriteLine(CatAndMouse(x, y, z));
        }
    }
}
