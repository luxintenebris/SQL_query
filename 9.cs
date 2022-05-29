using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            string[] line = Console.ReadLine().Split(' ');
            int i = 1, s = 0;

            while (i <= n)
            {
                s += Int32.Parse(line[i-1]);
                i *= 2;   
            }
            Console.WriteLine(s);
        }
    }
}
