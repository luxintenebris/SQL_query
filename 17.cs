using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int a = int.Parse(line[0]);
            int b = int.Parse(line[1]);
            int c = 0, max = 0;
            List<int> l = new List<int>();
            for (int i = a; i <= b; i++)
            {
                for (int j = 1; j <= i/2; j++)
                {
                    if (i % j == 0)
                    {
                        c++;
                    }
                }
                if (c > max)
                {
                    max = c;
                }
                c = 0;
            }
            for (int i = a; i <= b; i++)
            {
                for (int j = 1; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        c++;
                    }
                }
                if (c == max)
                {
                    l.Add(i);
                }
                c = 0;
            }
            Console.WriteLine(l.Count);
            for (int i = 0; i < l.Count - 1; i++)
            {
                Console.Write(l[i] + ",");
            }
            Console.WriteLine(l[l.Count - 1]);
        }
    }
}
