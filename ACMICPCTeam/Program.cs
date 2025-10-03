using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static List<int> AcmTeam(List<string> topic)
    {
        int n = topic.Count;
        int m = topic[0].Length;
        
        int maxTopics = 0;
        int teamCount = 0;
        
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int knownTopics = 0;
                
                for (int k = 0; k < m; k++)
                {
                    if (topic[i][k] == '1' || topic[j][k] == '1')
                    {
                        knownTopics++;
                    }
                }
                
                if (knownTopics > maxTopics)
                {
                    maxTopics = knownTopics;
                    teamCount = 1;
                }
                else if (knownTopics == maxTopics)
                {
                    teamCount++;
                }
            }
        }
        
        return new List<int> { maxTopics, teamCount };
    }
    
    static void Main(string[] args)
    {
        string[] firstLine = Console.ReadLine().TrimEnd().Split(' ');
        int n = Convert.ToInt32(firstLine[0]);
        int m = Convert.ToInt32(firstLine[1]);
        
        List<string> topic = new List<string>();
        for (int i = 0; i < n; i++)
        {
            topic.Add(Console.ReadLine());
        }
        
        List<int> result = AcmTeam(topic);
        
        foreach (int res in result)
        {
            Console.WriteLine(res);
        }
    }
}
