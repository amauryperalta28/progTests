using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 29, 5, 200, 35, 2, 9 };

            var result = list.OrderBy(x => x);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
