using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1._4_Divider
{
    class DivideIt
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите первое целое число");
                string temp = Console.ReadLine();
                int firstInt = Int32.Parse(temp);

                Console.WriteLine("Введите второе целое число");
                string temp2 = Console.ReadLine();
                int secondInt = Int32.Parse(temp2);

                int result = firstInt / secondInt;
                Console.WriteLine("Результат деления {0} на {1} = {2}", firstInt, secondInt, result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Исключение: " + e);
            }

            Console.ReadKey();
        }
    }
}
