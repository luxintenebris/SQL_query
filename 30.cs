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

            int c = 0;
            
            for (int i = 0; i < n; i++)
            {
                int s = l[i];
                if (l[i] == 0) c++;
                for (int j = i + 1; j < n; j++)
                {
                    s += l[j];
                    if (s == 0)
                    {
                        c++;
                    }
                }
            }
            Console.WriteLine(c);
        }
    }
}
