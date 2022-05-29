using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string[] line = Console.ReadLine().Split(' ');
           string[] line1 = Console.ReadLine().Split(' ');
           int n = Int32.Parse(line[0]);
           int w = Int32.Parse(line[1]);
           long s = 0, j = 0;
           for (int i = 0; i < n; i++)
            {
                int k = Int32.Parse(line1[i]);
                if (s + k <= w)
                {
                    s += k;
                    j++;
                }
            }
            Console.WriteLine(j + " " + s);
        }
    }
}
