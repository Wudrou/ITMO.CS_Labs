using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_Utils
{
    class Utils
    {
        static int Greater(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int y = int.Parse(Console.ReadLine());

            int greater = Greater(x, y);
            Console.WriteLine("The greater value is " + greater);

            Console.WriteLine("Before swap: " + x + "," + y);
            Swap(ref x, ref y);
            Console.WriteLine("After swap: " + x + "," + y);

            Console.ReadKey();
        }
    }
}
