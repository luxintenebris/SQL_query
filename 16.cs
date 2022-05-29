using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int a = int.Parse(line[0]);
            int b = int.Parse(line[1]);
            int c = int.Parse(line[2]);
            int d = b * b - 4 * a * c;
            if (a != 0)
            {
                if (d < 0)
                {
                    Console.WriteLine(0);
                }
                else if (d == 0)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(2);

                }
            }
            else if (b != 0)
            {
                Console.WriteLine(1);
            }
            else if (c != 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(-1);
            }

        }
    }
}
