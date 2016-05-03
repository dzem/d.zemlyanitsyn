using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заполнить массив длиной N случайными числами. Ввести с консоли число A. Вывести Yes, если число A есть в массиве, No - в противном случае.
            uint n = 0;
            int a;
            bool exist = false;
            Random r = new Random();

            Console.WriteLine("Введите N:");
            UInt32.TryParse(Console.ReadLine(), out n);
            int[] array = new int[n];

            Console.WriteLine("Массив:");
            for (int i = 0; i < n; i++)
            {
                array[i] = r.Next(16);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\nВведите A:");
            Int32.TryParse(Console.ReadLine(), out a);

            foreach (int number in array)
            {
                if (number == a)
                {
                    exist = true;
                }
            }

            if (exist)
            {
                Console.WriteLine("Yes. I'm your father!");
            }
            else Console.WriteLine("NOOOOOOOOOOOOOOOOOOOOOOO!!!");
            Console.ReadKey();
        }
    }
}
