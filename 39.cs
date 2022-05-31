using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
           
            string res = "";

            
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i]  >= 'a' && line[i] <= 'z' 
                 || line[i] >= 'A' && line[i] <= 'Z')
                {
                    res += line[i];
                }
                else
                {
                    res += ',';
                }
            }
            string[] line1 = res.Split(',');
            List<string> result = new List<string>();
            for (int i = 0; i < line1.Length; i++)
            {
                result.Add(line1[i]);
            }
            int с = 0;
            for (int i = 0; i < result.Count; i++)
            {
                if (line1[i].Length > 0)
                {
                    с++;
                }
            }
            Console.WriteLine(с);
        }
    }
}
