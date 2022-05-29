using System;


namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int i = 1, j = 2;
            while (i < n)
            {
                i += j;
                j++;
            }
            Console.WriteLine(j - 1);
        }
    }
}
