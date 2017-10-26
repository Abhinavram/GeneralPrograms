using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNnumbers
{
    class Program
    {
        int Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Enter the Nth number");
            n = Convert.ToInt32(Console.ReadLine());

            int a = SumOfNumbers(int n);

            Console.WriteLine("Sum is ", a);
            Console.ReadKey();               
        }
        int SumOfNumbers(int x)
        {
            int sum = 0;
            while(x!=0)
            {
                sum = sum + x % 10;
                x = x / 10;
            }
        }

    }
}
