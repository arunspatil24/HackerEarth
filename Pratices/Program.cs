using System;
using System.Collections;
class Program
{
    static void Main(String[] args)
    {
        int t = int.Parse(Console.ReadLine());
        for (int i = 1; i <= t; i++)
        {
            int n = int.Parse(Console.ReadLine());
            int result = FindFacingSeat(n);
            Console.Write(result + " ");
            FindTypeOfSeat(n);
        }
    }
    static int FindFacingSeat(int n)
    {
        if (n >= 1 && n <= 108)
        {
            if (n == 108)
            {
                return 97;
            }
            else
            {
                int q = n / 12;
                int rem = n % 12;
                if (rem == 0)
                {
                    q = q - 1;
                }
                int a = q * 12;
                int b = n - a;
                return a + (13 - b);
            }
        }
        return 0;
    }
    static void FindTypeOfSeat(int n)
    {
        Hashtable dt = new Hashtable();
        dt.Add(1, "WS");
        dt.Add(2, "MS");
        dt.Add(3, "AS");
        dt.Add(6, "WS");
        dt.Add(5, "MS");
        dt.Add(4, "AS");
        if (n > 6)
        {
            int rem = n % 6;
            if (rem == 0)
            {
                string st = (string)dt[6];
                Console.Write(st);
                Console.WriteLine();

            }
            else
            {
                string st = (string)dt[rem];
                Console.Write(st);
                Console.WriteLine();
            }
        }
        else
        {
            string st = (string)dt[n];
            Console.Write(st);
            Console.WriteLine();
        }
    }
}