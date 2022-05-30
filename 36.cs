using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            List<string> l = new List<string>();
            for (int i = 0; i < n; i++)
            {
                l.Add(Console.ReadLine());
            }
            List<char> l2 = new List<char>();
            l2.Add('e');
            l2.Add('y');
            l2.Add('u');
            l2.Add('i');
            l2.Add('o');
            l2.Add('a');

            for (int i = 0; i < l.Count; i++)
            {
                int c = 0;
                for (int j = 0; j < l[i].Length; j++)
                {
                    if (l2.Contains(l[i][j]))
                    {
                        c++;
                        if (c == 3)
                        {
                            l.Remove(l[i]);
                            i--;
                            break;
                        }
                    }
                    else
                    {
                        c = 0;
                    }
                }
                
            }
            for (int i = 0; i < l.Count; i++)
            {
                Console.WriteLine(l[i]);
            }
        }
    }
}
