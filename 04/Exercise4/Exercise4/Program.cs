using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a sentence");
            string input = Console.ReadLine();

            Console.WriteLine(input.Replace(" ", ""));

            Console.ReadKey();
        }
    }
}
