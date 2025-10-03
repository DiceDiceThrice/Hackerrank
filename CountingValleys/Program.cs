using System;

class Solution
{
    static int CountingValleys(int steps, string path)
    {
        int seaLevel = 0;   
        int valleys = 0;      
        bool inValley = false; 

        foreach (char step in path)
        {
            if (step == 'U') seaLevel++;
            else seaLevel--;

            if (seaLevel < 0 && !inValley)
            {
                inValley = true;
            }

            if (seaLevel == 0 && inValley)
            {
                valleys++;
                inValley = false;
            }
        }

        return valleys;
    }

    static void Main(string[] args)
    {
        int steps = int.Parse(Console.ReadLine()); 
        string path = Console.ReadLine();        

        int result = CountingValleys(steps, path);
        Console.WriteLine(result);
    }
}
