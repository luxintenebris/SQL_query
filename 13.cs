using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            string[] line = Console.ReadLine().Split(' ');
            int min = 10001;
            for (int i = 0; i < n; i++)
            {
                int k = Int32.Parse(line[i]);
                if (min > k)
                {
                    min = k;
                }
            }
            int c = 0;
            for (int i = 0; i < n; i++)
            {
                int k = Int32.Parse(line[i]);
                if (min == k)
                {
                    c++;
                }
            }
            Console.WriteLine(c);
        }
    }
}
