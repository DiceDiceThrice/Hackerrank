using System;

class Solution
{
    static string timeConversion(string s)
    {
        string period = s.Substring(s.Length - 2); 
        string timeWithoutPeriod = s.Substring(0, s.Length - 2);
        string[] timeParts = timeWithoutPeriod.Split(':');
        
        int hour = int.Parse(timeParts[0]);
        string minute = timeParts[1];
        string second = timeParts[2];
        
        if (period == "AM")
        {
            if (hour == 12)
            {
                hour = 0;
            }
        }
        else // PM
        {
            if (hour != 12)
            {
                hour += 12;
            }
        }
        
        return hour.ToString("D2") + ":" + minute + ":" + second;
    }

    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        string result = timeConversion(s);
        Console.WriteLine(result);
    }
}
