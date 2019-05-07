using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToggleString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int length = str.Length;
            char[] str2 = str.ToCharArray();
            for(int i = 0; i < length; i++)
            {
                char d = ' ';
                if (char.IsLower(str2[i]))
                {
                    d=char.ToUpper(str2[i]);
                    str2[i] = d;
                }
                else
                {
                    d = char.ToLower(str2[i]);
                    str2[i] = d;
                }
            }
            str = "";
            for(int i = 0; i < length; i++)
            {
                str +=str2[i];
            }
            Console.WriteLine(str);
        }
    }
}
