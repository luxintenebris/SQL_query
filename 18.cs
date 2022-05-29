using System;


namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            string[] line = Console.ReadLine().Split(' ');
            int s = 2, k = 1, sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (s % 2 == 0 && k != 0)
                {
                    sum += Int32.Parse(line[i]);
                    k--;
                }
                else if (k == 0)
                {
                    k = s;
                    s++;
                    i--;
                }
                else if (s % 2 != 0 && k != 0)
                {
                    sum -= Int32.Parse(line[i]);
                    k--;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
