using System;
class Program
{
    static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int result = Fact(n);
        Console.WriteLine(result);
    }
    static int Fact(int n)
    {
        if (n == 0)
            return 1;
        return n * Fact(n - 1);
    }
}