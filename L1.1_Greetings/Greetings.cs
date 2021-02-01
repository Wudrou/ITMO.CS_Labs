using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1._1_Greetings
{
    class Greetings
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пожалуйста, введите своё ИМЯ");
            string myName = Console.ReadLine();
            Console.WriteLine("Привет {0}", myName);  //также можно "Привет " + myName

            Console.ReadKey();
        }
    }
}
