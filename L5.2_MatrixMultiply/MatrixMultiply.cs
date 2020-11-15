using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5._2_MatrixMultiply
{
    class MatrixMultiply
    {
        static void OutPut(int[,] result)
        {
            for(int r = 0; r < result.GetLength(0); r++)
            {
                for (int c = 0; c < result.GetLength(1); c++)
                {
                    Console.Write("{0} ", result[r, c]);
                }
                Console.WriteLine();
            }
        }
        static int[,] Multiply(int[,] a, int[,] b)
        {
            int[,] result = new int[2, 2];
            for (int r = 0; r < 2; r++)
            {
                for (int c = 0; c < 2; c++)
                {
                    result[r, c] += a[r, 0] * b[0, c] + a[r, 1] * b[1, c];
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter four numbers:");
            int[,] a = new int[2, 2];
            a[0, 0] = int.Parse(Console.ReadLine());
            a[0, 1] = int.Parse(Console.ReadLine());
            a[1, 0] = int.Parse(Console.ReadLine());
            a[1, 1] = int.Parse(Console.ReadLine());

            int[,] b = new int[2, 2] { { 5, 6 }, { 7, 8 } };

            int[,] result = Multiply(a, b);

            OutPut(result);

            Console.ReadKey();
        }
    }
}
