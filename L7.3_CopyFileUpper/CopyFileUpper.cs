using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7._3_CopyFileUpper
{
    class CopyFileUpper
    {
        static void Main(string[] args)
        {
            //StreamReader srFrom;
            //StreamWriter swTo;

            Console.WriteLine("Copy from:");
            string sFrom = Console.ReadLine();

            Console.WriteLine("Copy to:");
            string sTo = Console.ReadLine();

            Console.WriteLine("Copy from {0} to {1}", sFrom, sTo);

            try
            {
                StreamReader srFrom = new StreamReader(sFrom);
                StreamWriter swTo = new StreamWriter(sTo);

                while (srFrom.Peek() !=-1)
                {
                    string sBuffer = srFrom.ReadLine();
                    sBuffer = sBuffer.ToUpper();
                    swTo.WriteLine(sBuffer);
                }

                swTo.Close();
                srFrom.Close();
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("Input file not found");
            }
            catch(Exception e)
            {
                Console.WriteLine("Unexpected exception");
                Console.WriteLine(e.ToString());
            }

            Console.ReadKey();
        }
    }
}
