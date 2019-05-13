using System;
class Program
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        int x = 0;
        int y = 0;
        char[] ch = str.ToCharArray();
        for (int i = 0; i < str.Length; i++)
        {
            switch (ch[i])
            {
                case 'L':
                    x -= 1;
                    break;
                case 'R':
                    x += 1;
                    break;
                case 'U':
                    y += 1;
                    break;
                case 'D':
                    y -= 1;
                    break;
            }
        }
        Console.WriteLine(x + " " + y);
    }
}