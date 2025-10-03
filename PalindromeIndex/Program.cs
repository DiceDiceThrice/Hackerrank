using System;
using System.IO;

class Result
{
    public static int palindromeIndex(string s)
    {
        int left = 0;
        int right = s.Length - 1;
        
        while (left < right)
        {
            if (s[left] != s[right])
            {
                if (IsPalindrome(s, left + 1, right))
                {
                    return left;
                }
                if (IsPalindrome(s, left, right - 1))
                {
                    return right;
                }
                return -1;
            }
            left++;
            right--;
        }
        
        return -1;
    }
    
    private static bool IsPalindrome(string s, int left, int right)
    {
        while (left < right)
        {
            if (s[left] != s[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            int result = Result.palindromeIndex(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
