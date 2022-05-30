using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    internal class Program
    {
        static void minim(List<int> a, int l, int r)
        {
            int min = 101;
            for (int i = l - 1; i <= r - 1; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine(min);
        }

        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            string[] line = Console.ReadLine().Split(' ');
            List<int> a = new List<int>();
           for (int i = 0; i < n; i++)
            {
                a.Add(Int32.Parse(line[i]));
            }
            int m = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string[] line1 = Console.ReadLine().Split(' ');

                minim(a, Int32.Parse(line1[0]), Int32.Parse(line1[1]));
            }
        }
    }
}
