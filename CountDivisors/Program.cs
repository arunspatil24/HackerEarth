using System;
class Program
{
    static void Main(String[] args)
    {
        string str = Console.ReadLine();
        string[] str2 = str.Split(' ');
        int l = int.Parse(str2[0]);
        int r = int.Parse(str2[1]);
        int k = int.Parse(str2[2]);
        int count = 0;
        for (int i = l; i <= r; i++)
        {
            if (i % k == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}