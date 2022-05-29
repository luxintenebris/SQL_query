using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            string[] line = Console.ReadLine().Split(' ');
            int s = 0;
            int fl = 1;
            for (int i = 0; i < n; i++)
            {
                s += Int32.Parse(line[i]) * fl;
                fl *= -1;
            }
            Console.WriteLine(s);
        }
    }
}
