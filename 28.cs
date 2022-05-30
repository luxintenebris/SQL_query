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
            List<int> a = new List<int>();
           for (int i = 0; i < n; i++)
            {
                a.Add(Int32.Parse(line[i]));
            }
            

            int[] sh = new int[5];

            for (int i = 0; i < n; i++)
            {
                sh[a[i]]++;
            }
            for (int i = 0; i < 5; i++)
            {
                if (sh[i] != 0)
                Console.WriteLine(i + " " + sh[i]);
            }
        }
    }
}
