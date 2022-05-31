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

            int min = 101;

            for (int i = 0; i < n; i++)
            {
                if (l[i] < min)
                {
                    min = l[i];
                }
            }

            List<int> res = new List<int>();

            for (int i = 0; i < n; i++)
            {
                if (l[i] == min)
                {
                    res.Add(i + 1);
                }
            }
            if (res.Count % 2 == 0)
            Console.WriteLine(res[res.Count / 2 - 1]);
            else
                Console.WriteLine(res[res.Count / 2]);

        }
    }
}
