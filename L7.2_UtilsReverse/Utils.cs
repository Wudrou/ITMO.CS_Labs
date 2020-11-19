using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7._2_UtilsReverse
{
    class Utils
    {
        public static void Reverse(ref string s)
        {
            string sRev = "";

            for (int k = s.Length - 1; k >=0; k--)
            {
                sRev = sRev + s[k];
            }
            s = sRev;
        }
        //static int Greater(int a, int b)
        //{
        //    if (a > b)
        //    {
        //        return a;
        //    }
        //    else
        //    {
        //        return b;
        //    }
        //    // Alternative version - more terse
        //    // return (a>b) > (a) : (b);
        //}
        //static void Swap(ref int a, ref int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}
        //static bool Factorial(int n, out int answer)
        //{
        //    int k;
        //    int f;
        //    bool ok = true;
        //    if (n < 0)
        //        ok = false;
        //    try
        //    {
        //        checked
        //        {
        //            f = 1;
        //            for (k = 2; k <= n; ++k)
        //            {
        //                f = f * k;
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        f = 0;
        //        ok = false;
        //    }
        //    answer = f;
        //    return ok;
        //}
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter first number:");
        //    int x = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter second number:");
        //    int y = int.Parse(Console.ReadLine());

        //    //Using Greater
        //    int greater = Greater(x, y);
        //    Console.WriteLine("The greater value is " + greater);

        //    //Using Swap
        //    Console.WriteLine("Before swap: " + x + "," + y);
        //    Swap(ref x, ref y);
        //    Console.WriteLine("After swap: " + x + "," + y);

        //    //Using Factorial
        //    int f;
        //    bool ok;
        //    Console.WriteLine("Number for factorial:");
        //    x = int.Parse(Console.ReadLine());
        //    ok = Factorial(x, out f);
        //    if (ok)
        //    {
        //        Console.WriteLine("Factorial(" + x + ") = " + f);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Cannot compute this factorial");
        //    }

        //    Console.ReadKey();
        //}
    }
}
