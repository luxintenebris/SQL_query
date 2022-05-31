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
            int n1 = Int32.Parse(Console.ReadLine());
            string[] line1 = Console.ReadLine().Split(' ');
            List<int> l = new List<int>();
            List<int> c = new List<int>();
            for (int i = 0; i < n; i++)
            {
                l.Add(Int32.Parse(line[i]));
            }
            List<int> l1 = new List<int>();
            for (int i = 0; i < n1; i++)
            {
                l1.Add(Int32.Parse(line1[i]));
            }

            List<int> res = new List<int>();

            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < l1.Count; i++)
            {
                if (!map.ContainsKey(l1[i]))
                map.Add(l1[i], 0);
            }
            for (int i = 0; i < l1.Count; i++)
            {
                map[l1[i]]++;
            }
   
            for (int i = 0; i < n; i++)
            {
                if (map.ContainsKey(l[i]) && map[l[i]] > 0)
                {
                    res.Add(l[i]);
                }
            }

            Console.WriteLine(res.Count);

            for (int i = 0; i < res.Count; i++)
            {
                Console.Write(res[i] + " ");
            }
        }
    }
}
