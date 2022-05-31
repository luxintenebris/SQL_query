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
            List<int> res = new List<int>();
            for (int j = 0; j < n; j++)
            {
                res.Add(Int32.Parse(line[j]));
            }
            
            int i = n - 1;
            while (i >= 0)
            {
                res[i]++;
                if (res[i] != 10)
                {
                    break;
                }

                else if (i == 0)
                {
                    res.Insert(0, 1);

                    res[1] = 0;
                    i--;
                }
                else
                {
                    res[i] = 0;
                    i--;
                }


            } 
            Console.WriteLine(res.Count);
            for (int j = 0; j < res.Count; j++)
                {
                    Console.Write(res[j] + " ");
                }

        }
    }
}
