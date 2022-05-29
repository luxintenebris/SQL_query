using System;


namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            string[] line = Console.ReadLine().Split(' ');
            int[] mas = new int[10000];
            for (int i = 0; i < n; i++)
            {
                int k = Int32.Parse(line[i]);
                mas[k]++;
            }
            int max = 0; int j = 0;
            for (int i = 0; i < 10000; i++)
            {
                if (mas[i] > max)
                {
                    j = i;
                    max = mas[i];
                }
            }
            Console.WriteLine(j + " " + max);

        }
    }
}
