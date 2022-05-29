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
            int mini = -1;
            for (int i = 0; i < n; i++)
            {
                int k = Int32.Parse(line[i]);
                if (k < min)
                {
                    min = k;
                    mini = i;
                }
            }

                Console.WriteLine(mini + 1);

        }
    }
}
