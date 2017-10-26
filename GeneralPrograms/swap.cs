using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralPrograms
{
    class swap
    {
        public static void main(string[] args)
        { 
        int num1, num2, temp;
        Console.WriteLine("Enter the First Number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Second Number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        temp = num1;
        num1 = num2;
        num2 = temp;
            Console.WriteLine("Swapped Numbers");
            Console.WriteLine("First Number is ", num1);
            Console.WriteLine("Second Number is ", num2);
            Console.ReadKey();

        }

    }
}
