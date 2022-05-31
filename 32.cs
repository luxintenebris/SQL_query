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

            int n1 = Int32.Parse(Console.ReadLine());
            string[] line1 = Console.ReadLine().Split(' ');

            List<int> l1 = new List<int>();

            for (int i = 0; i < n1; i++)
            {
                l1.Add(Int32.Parse(line1[i]));
            }

            if (l1.Count > l.Count)
            {
                Console.WriteLine(-1);
            }
            else if (l1.Count < l.Count)
            {
                Console.WriteLine(1);
            }
            else
            {
                bool fl = true;
                int i = 0;
                while (i < l.Count)
                {
                    if (l1[i] > l[i])
                    {
                       Console.WriteLine(-1);
                        fl = false;
                        break;
                    }
                    else if (l1[i] < l[i])
                    {
                        Console.WriteLine(1);
                        fl = false;
                        break;
                    }
                    i++;
                }
                if (fl) Console.WriteLine(0);
            }


        }
    }
}
