using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int h = 0;
            string s = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '>' )
                {
                    if (str[i-2]!='/') h++;
                    s += ">\n"; 
                    if (i + 2 < str.Length && str[i + 2] == '/')
                    {        
                        h--;
                    }
                }
                else if (str[i] == '<')
                {
                    for (int j = 0; j < h * 2; j++)
                    {
                        s += " ";
                    } 
                    s += "<";
                }
                else
                {
                    s += str[i];
                    
                }
            }
            Console.WriteLine(s);
        }
    }
}
/**/