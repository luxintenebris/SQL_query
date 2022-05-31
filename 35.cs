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

            List<int> res = new List<int>();

            bool fl = true;
          

            for (int i = 0; i < n; i++)
            {
                res.Add(Int32.Parse(line[i]));
                List<int> res1 = new List<int>();
                

                for (int j = 0; j < l.Count/res.Count; j++)
                {
                    for (int k = 0; k < res.Count; k++)
                    {
                        res1.Add(res[k]);
                    }
                }
             
                for (int j = 0; j < l.Count; j++)
                {
                    if (l.Count == res1.Count)
                    {
                        if (l[j] != res1[j])
                        {
                            res1.Clear();
                            fl = false;
                            break;
                        }
                    }
                    else
                    {
                        res1.Clear();
                        fl = false;
                        break;
                    }

                }
               
                if (fl) break;
                fl = true;

                //res * l.count/res.count
                //res==l
            }
            Console.WriteLine(res.Count);

        }
    }
}
