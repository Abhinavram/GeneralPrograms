using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter a number: ");
            i = Convert.ToInt32(Console.ReadLine());
            if(i%2==0)
            {
                Console.Write("Entered Number is even");
            }
            else
            {
                Console.Write("Entered number is odd");
            }

            Console.ReadKey();
        }
    }
}
