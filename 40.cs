using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    internal class Program
    {
        static string shift(string str)
        {
            str = str.Insert(0, Convert.ToString(str[str.Length - 1]));
            str = str.Remove(str.Length - 1);
            return str;
        }

        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            List<string> l = new List<string>();

            for (int i = 0; i < str.Length; i++)
            {
                l.Add(str);
                str = shift(str);
            }
            l.Sort();

            Console.WriteLine(l[0]);
           

        }
    }
}
