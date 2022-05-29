using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int a = Int32.Parse(line[0]), b = Int32.Parse(line[1]), i = 0;

           while (a > 0 && b > 0)
            {
                int k = Math.Max(a, b);
                if (a == k)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
                i++;
            }
            Console.WriteLine(i + " " + Math.Max(a, b));
        }
    }
}
