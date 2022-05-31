using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(',');
            int k = Int32.Parse(Console.ReadLine());
            List<string> res = new List<string>();
            for (int i = 0; i < line.Length; i++)
            {
                res.Add(line[i]);
            }
            for (int i = 0; i < res.Count; i++)
            {
                if (res[i].Length < k)
                {
                    res.Remove(res[i]);
                    i--;
                }   
            }
           for (int i = 0; i < res.Count; i++)
            {
                if (i!=res.Count - 1)
                Console.Write(res[i] + ",");
                else
                Console.Write(res[i]);
            }
        }
    }
}
