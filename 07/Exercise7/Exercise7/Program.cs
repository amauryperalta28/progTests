using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ex = new List<string> { "How (are) you", "How (are you" };

            ex.ForEach(x => System.Console.WriteLine(IsValidString(x)));

            Console.ReadKey();
        }

        static bool IsValidString(string sentence)
         =>  (sentence.Count(x => x == '(') + sentence.Count(x => x == ')')) % 2 == 0 ;
    }
}
