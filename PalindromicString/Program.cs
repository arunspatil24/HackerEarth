using System;
class Program
{
    static void Main(String[] args)
    {
        string str = Console.ReadLine();
        string rev = "";
        for (int i = 0, j = str.Length - 1; j >= 0; i++, j--)
        {
            rev = rev + str[j];
        }
        if (str.Equals(rev))
        {
            Console.WriteLine("YES");
        }
        else
            Console.WriteLine("NO");
    }
}