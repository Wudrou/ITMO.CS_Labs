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
        static void Main()
        {
            string message;

            // Get an input string
            Console.WriteLine("Enter string to reverse:");
            message = Console.ReadLine();

            // Reverse the string
            Reverse(ref message);

            // Display the result
            Console.WriteLine(message);

            Console.ReadLine();
        }
    }
}
