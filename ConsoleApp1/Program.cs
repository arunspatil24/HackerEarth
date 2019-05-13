using System;
using System.Linq;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First String");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter the Second String");
            string str2 = Console.ReadLine();
            char[] l1 = str1.ToCharArray();
            SortedList sl = new SortedList();
            for(int i = 0; i < l1.Length; i++)
            {
                sl.Add(i, l1[i]);
            }
            //foreach (DictionaryEntry item in sl)
            //{
            //    Console.WriteLine(item.Value);
            //}
            char[] l2 = str2.ToCharArray();
            SortedList sl2 = new SortedList();
            for (int i = 0; i < l2.Length; i++)
            {
                sl2.Add(i, l2[i]);
            }

            int count = 0;
            int n1 = str1.Length;
            int n2 = str2.Length;
            for(int i = 0; i < n1; i++)
            {
                for(int j = 0; j < n2; j++)
                {
                    if (sl.IndexOfValue(sl2.GetByIndex(j)))
                    {

                    }
                }
            }
        }

    }
}
