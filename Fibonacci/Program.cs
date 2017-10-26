using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c=0;
            Console.WriteLine("Enter Limit");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Numbers are ", a, b);

            for (int i = 0; i <= n; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
            Console.ReadKey();
        }
    }
}
