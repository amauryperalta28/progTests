using System;
namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "aBc";
            string result = "";

            for (int i = word.Length-1; i >= 0; i--)
            {
                result += word[i];
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
