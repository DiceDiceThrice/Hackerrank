using System;
using System.IO;

class Result
{
    public static int minimumNumber(int n, string password)
    {
        bool hasDigit = false;
        bool hasLower = false;
        bool hasUpper = false;
        bool hasSpecial = false;
        
        string specialCharacters = "!@#$%^&*()-+";
        
        foreach (char c in password)
        {
            if (char.IsDigit(c))
                hasDigit = true;
            else if (char.IsLower(c))
                hasLower = true;
            else if (char.IsUpper(c))
                hasUpper = true;
            else if (specialCharacters.Contains(c))
                hasSpecial = true;
        }
        
        int missingCriteria = 0;
        if (!hasDigit) missingCriteria++;
        if (!hasLower) missingCriteria++;
        if (!hasUpper) missingCriteria++;
        if (!hasSpecial) missingCriteria++;
        
        return Math.Max(missingCriteria, 6 - n);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string password = Console.ReadLine();

        int answer = Result.minimumNumber(n, password);

        textWriter.WriteLine(answer);

        textWriter.Flush();
        textWriter.Close();
    }
}
