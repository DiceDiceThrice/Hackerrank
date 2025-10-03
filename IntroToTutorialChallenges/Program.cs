using System;

class Solution
{
    static int IntroTutorial(int V, int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == V)
                return i;
        }
        return -1;
    }

    static void Main(string[] args)
    {
        int V = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(input, int.Parse);
        Console.WriteLine(IntroTutorial(V, arr));
    }
}
