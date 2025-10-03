using System;

class Solution
{
    static void BonAppetit(int[] bill, int k, int b)
    {
        int total = 0;

        for (int i = 0; i < bill.Length; i++)
        {
            if (i != k)
            {
                total += bill[i];
            }
        }

        int fairShare = total / 2;

        if (b == fairShare)
        {
            Console.WriteLine("Bon Appetit");
        }
        else
        {
            Console.WriteLine(b - fairShare);
        }
    }

    static void Main(string[] args)
    {
        string[] firstInput = Console.ReadLine().Split(' ');
        int n = int.Parse(firstInput[0]);
        int k = int.Parse(firstInput[1]);

        string[] billItems = Console.ReadLine().Split(' ');
        int[] bill = Array.ConvertAll(billItems, int.Parse);

        int b = int.Parse(Console.ReadLine());

        BonAppetit(bill, k, b);
    }
}
