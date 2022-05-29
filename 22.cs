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
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (l[i] % l[j] == 0 && i != j)
                    {
                        k++;
                        
                    }
                }
            }
            Console.WriteLine(k);
           
        }
    }
}
