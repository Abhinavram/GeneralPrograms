using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 9, 2, 26, 44 };
            int temp;
            Console.WriteLine("The numbers are: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            for(int j = 0; j <= a.Length - 2; j++)
            {
                for (int i = 0; i < a.Length- 2; i++)
                {
                    if(a[i] > a[i+1])
                    {
                        temp = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = temp;
                    }
                }
            }
            Console.WriteLine("The soreted Numbers are");
            foreach (int array in a)
                Console.WriteLine(array + " ");
            Console.ReadKey();
        }
    }
}
