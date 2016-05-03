using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заполнить 2 матрицы размерности NxN случайными числами. Вывести на консоль. Сложить 2 матрицы. Вывести результат.

            uint n = 0;
            Random r = new Random();

            Console.WriteLine("Введите размерность матриц:");
            UInt32.TryParse(Console.ReadLine(), out n);
            int[,] matrix1 = new int[n,n];
            int[,] matrix2 = new int[n,n];
            int[,] result = new int[n,n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix1[i,j] = r.Next(2016);
                    matrix2[i,j] = r.Next(2016);
                    result[i,j] = matrix1[i,j] + matrix2[i,j];
                }
            }

            Console.WriteLine("Первая матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix1[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Вторая матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix2[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Сумма матриц:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(result[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
