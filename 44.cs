using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            Dictionary<string, char> map = new Dictionary<string, char>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                map.Add(line[1], Convert.ToChar(line[0]));
            }

            string str = Console.ReadLine();
            string res = "";
            var keys = map.Keys;
            int c = 0;
            for (int i = 0; i < str.Length; )
            {
                foreach(var k in keys)
                {
                    c = 0;
                    if (str[i] == k[0])
                    {
                        for (int j = 0; j <k.Length; j++)
                        {
                            
                            if (i+j < str.Length && k[j] == str[i + j])
                            {
                                c++;
                            }
                        }
                        //Console.WriteLine(c + " "+k.Length);
                        if (c == k.Length)
                        {
                            res += map[k];
                            i += c; 
                           // Console.WriteLine(i + "!");
                            break;
                        }
                        

                    }
                }
            }
            Console.WriteLine(res);
        }
    }
}
