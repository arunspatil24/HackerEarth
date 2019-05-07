using System;
class Program
{
    static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 2; i < n; i++)
        {
            int count = 0;
            for (int j = 1; j < i; j++)
            {
                if (i % j == 0)
                    count++;
            }
            if (count < 2)
                Console.Write(i + " ");
        }

    }
}