using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            List<int> l = new List<int>();
            string substr = Console.ReadLine();
            int c = 0;
            for (int i = 0; i < str.Length - substr.Length + 1; i++)
            {
                c = 0;
                for (int j = 0; j < substr.Length; j++)
                {
                    if (str[i + j] == substr[j] || substr[j] == '?')
                    {
                        c++;
                    }
                }
                
                if (substr.Length == c)
                {
                    l.Add(i + 1);
                }
            }
            for (int i = 0; i < l.Count; i++)
            {
                Console.Write(l[i] + " ");
            }
        }
    }
}
