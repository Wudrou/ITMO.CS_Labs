using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5._1_FileDetails
{
    class FileDetails
    {
        static void Summorize(char[] contents)
        {
            int vowels = 0, consonants = 0, lines = 0;
            foreach (char current in contents)
            {
                if (Char.IsLetter(current))
                {
                    if ("AEIOUaeiou".IndexOf(current) != -1)
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
                else if (current == '\n')
                {
                    lines++;
                }
            }
            Console.WriteLine("\nКоличество символов в файле: {0}", contents.Length);
            Console.WriteLine("Количество гласных в файле: {0}", vowels);
            Console.WriteLine("Количество согласных в файле: {0}", consonants);
            Console.WriteLine("Количество строк в файле: {0}", lines);

        }

        static void Main(string[] args)
        {
            string fileName = args[0];

            FileStream stream = new FileStream(fileName, FileMode.Open);

            StreamReader reader = new StreamReader(stream);

            int size = (int)stream.Length;

            char[] contents = new char[size];

            for (int i = 0; i < size; i++)
            {
                contents[i] = (char)reader.Read();
            }

            foreach (char ch in contents)
            {
                Console.Write(ch);
            }

            Summorize(contents);

            Console.ReadKey();
        }
    }
}
