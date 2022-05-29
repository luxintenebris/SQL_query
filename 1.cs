using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int a = Int32.Parse(line[0]);
            int b = Int32.Parse(line[1]);
            Console.WriteLine(a + b);

        }
    }
}
