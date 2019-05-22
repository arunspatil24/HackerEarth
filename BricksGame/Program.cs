using System;
using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        string s2 = s.Substring(0, 2);
        int ch = 0;
        if (s[8] == 'P')
        {
            ch = int.Parse(s2) + 12;
            s2 = ch.ToString();
        }
        if (s[8] == 'A')
        {
            if (int.Parse(s2) == 12)
            {
                s2 = "00";
            }
        }
        
        for(int i = 2; i < s.Length - 2; i++)
        {
            s2 = s2 + s[i];
        }
        Console.WriteLine(s2);
    }
}