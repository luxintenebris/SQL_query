using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Find_Max(List<int> a)
        {
            int max = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > max) max = a[i];
            }
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] == max)  a[i] /= 2;
            }
        }
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            string[] line = Console.ReadLine().Split(' ');
            List<int> l = new List<int>();
            for (int i = 0; i < n; i++)
            {
                l.Add(Int32.Parse(line[i]));
            }
            Find_Max(l);
            Find_Max(l);
            for (int i = 0; i < n; i++)
            {
                Console.Write(l[i] + " ");
            }
        }
    }
}
