using System;
class Program
{
    static void Main(string[] args)
    {
        int l = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        string[] s = new string[n];
        for (int i = 0; i < n; i++)
        {
            s[i] = Console.ReadLine();
        }
        for (int i = 0; i < n; i++)
        {
            string[] str2 = s[i].Split(' ');
            int w = int.Parse(str2[0]);
            int h = int.Parse(str2[1]);
            CheckResult(l, w, h);
        }


    }
    public static void CheckResult(int l, int w, int h)
    {
        if (w < l || h < l)
        {
            Console.WriteLine("UPLOAD ANOTHER");
        }
        else
        {
            if (w == h)
            {
                Console.WriteLine("ACCEPTED");
            }
            else
            {
                Console.WriteLine("CROP IT");
            }
        }
    }
}