using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int d = n / 3;
            if (n % 3 == 2)
            {
                d++;
            }
            int f = d / 12;
            Console.WriteLine(f + " " + (d - f * 12));
        }
    }
}
