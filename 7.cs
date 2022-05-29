using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int k = 0;
            while(n%2 == 0)
            {
                k++;
                n /= 2;
            }
            Console.WriteLine(k);
        }
    }
}
