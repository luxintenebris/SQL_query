using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int c = 0;
                for (int j = 1; j <= i/2; j++)
                {
                    if (i % j == 0)
                    {
                        c++;
                    }
                }
                if (c == 1)
                {
                    Console.WriteLine(i);
                }
               
            }
        }
    }
}
