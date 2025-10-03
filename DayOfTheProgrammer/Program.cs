using System;

class Solution
{
    static string DayOfProgrammer(int year)
    {
        if (year == 1918)
        {
            return $"26.09.{year}";
        }

        if (year < 1918)
        {
            if (year % 4 == 0)
                return $"12.09.{year}";
            else
                return $"13.09.{year}";
        }

        else
        {
            if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                return $"12.09.{year}";
            else
                return $"13.09.{year}";
        }
    }

    static void Main(string[] args)
    {
        int year = int.Parse(Console.ReadLine());
        string result = DayOfProgrammer(year);
        Console.WriteLine(result);
    }
}
