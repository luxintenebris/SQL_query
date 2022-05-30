using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    internal class Program
    {
        static int maxis(List<int> a, int l)
        {
            int max = 0;
            for (int i = l + 1; i < a.Count; i++)
            {
                max = a[l];
                if (a[i] > max)
                {
                    max = a[i];
                    return max;
                }
            }
           // if (max == a[l])
             return 0;
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
            for (int i = 0; i < n; i++)
            {
                a[i] = maxis(a, i);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }

        }
    }
}
