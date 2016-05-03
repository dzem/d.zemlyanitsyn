using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Заполнить матрицу NxM случайными числами. Из каждой строки выбрать минимальный элемент, занести его в массив. 
            //Отсортировать полученный массив и вывести его значения в обратном порядке.

            uint n = 0;
            uint m = 0;
            Random r = new Random();

            Console.WriteLine("Введите количество строк матрицы:");
            UInt32.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Введите количество столбцов матрицы:");
            UInt32.TryParse(Console.ReadLine(), out m);
            int[,] matrix = new int[n, m];
            int[] array = new int[m];
            int[] result = new int[n];

            Console.WriteLine("Матрица:");
            for (uint i = 0; i < n; i++)
            {
                for (uint j = 0; j < m; j++)
                {
                    matrix[i,j] = r.Next(2016);
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Массив из минимальных элементов в каждой строке:");
            for (uint i = 0; i < n; i++)
            {
                for (uint j = 0; j < m; j++)
                {
                    array[j] = matrix[i, j];
                }
                result[i] = array.Min();
                Console.Write(result[i] + " ");
            }

            Console.WriteLine("\nОтсортированный и развёрнутый массив:");
            Array.Sort(result);
            for (uint i = n; i > 0; i--)
            {
                Console.Write(result[i-1] + " "); 
            }
            Console.ReadKey();
        }
    }
}
