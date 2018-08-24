using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 8, 10, 25 };
            Console.WriteLine("Max: {0}", list.Max());
            Console.WriteLine("Min: {0}", list.Min());

            Console.ReadKey();
        }
    }
}
