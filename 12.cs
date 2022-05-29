using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int a1 = Int32.Parse(line[0]);
            int b1 = Int32.Parse(line[1]);
            string[] line2 = Console.ReadLine().Split(' ');
            int a2 = Int32.Parse(line2[0]);
            int b2 = Int32.Parse(line2[1]);
            if (a1 == b2 && b1 + a2 == a1 
             || a1 == a2 && b1 + b2 == a1
             || b2 == b1 && a1 + a2 == b1
             || a2 == b1 && b2 + a1 == a2)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
