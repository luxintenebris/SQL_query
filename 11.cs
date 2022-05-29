using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = Int32.Parse(Console.ReadLine());
            if (age < 7)
            {
                Console.WriteLine("preschool child");
            }
            else if (age <= 17)
            {
                Console.WriteLine("schoolchild " + (age - 6));
            }
            else if (age <= 22)
            {
                Console.WriteLine("student " + (age - 17));
            }
            else
            {
                Console.WriteLine("specialist");
            }
        }
    }
}
