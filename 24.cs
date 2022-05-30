using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            string[] line = Console.ReadLine().Split(' ');
           
            List<int> l = new List<int>();

            for (int i = 0; i < n; i++)
            {
                l.Add(Int32.Parse(line[i]));
            }
            int max = n / 2;
            for (int i = 0; i < n/2; i++)
            {
                if (l[i]==l[n - i - 1])
                {
                    max--;
                }
            }
            Console.WriteLine(max);
        }
    }
}
