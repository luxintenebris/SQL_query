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
            string[] line1 = Console.ReadLine().Split(' ');
            string[] line2 = Console.ReadLine().Split(' ');
            a.Reverse(Int32.Parse(line1[0]) - 1, Int32.Parse(line1[1]) - Int32.Parse(line1[0]) + 1);
            a.Reverse(Int32.Parse(line2[0]) - 1, Int32.Parse(line2[1]) - Int32.Parse(line2[0]) + 1);



            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }

        }
    }
}
