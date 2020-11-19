using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7._4_InterfaceTest
{
    class Utils
    {
        public static bool IsItFormattable(object x)
        {
            if (x is IFormattable)
                return true;
            else
                return false;
        }
        static void Main()
        {
            int i = 0;
            ulong ul = 0;
            string s = "Test";

            Console.WriteLine("int: {0}", IsItFormattable(i));
            Console.WriteLine("ulong: {0}", IsItFormattable(ul));
            Console.WriteLine("String: {0}", IsItFormattable(s));

            Console.ReadKey();
        }
    }
}
