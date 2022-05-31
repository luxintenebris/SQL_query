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

            int[] res = new int[101];
            for (int i = 0; i < n; i++)
            {
                int k = Int32.Parse(line[i]);
                res[k]++;
            }
            int c = 0;
            for (int i = 0; i < res.Length; i++)
            {
                if (res[i] > 1)
                {
                    c++;
                }
            }
            Console.WriteLine(c);
            
            for (int i = 0; i < res.Length; i++)
            {
                if (res[i] > 1)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
