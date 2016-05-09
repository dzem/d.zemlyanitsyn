using System;
using System.Collections.Generic;

namespace Lesson3
{
    class Program
    {
        //Сделать методы для считывания целых чисел, дробных чисел. Сделать методы для вывода на консоль этих типов данных,
        //массивов целых и дробных чисел (можно доработать любое ДЗ).

        private static int GetInt()
        {
            Console.WriteLine("Введите целое число:");
            int value;
            return int.TryParse(Console.ReadLine(), out value) ? value : 0;
        }

        private static float GetFloat()
        {
            Console.WriteLine("Введите дробное число:");
            float value;
            return float.TryParse(Console.ReadLine(), out value) ? value : 0;
        }

        private static void Print(int value)
        {
            Console.WriteLine($"Целое число: {value}");
        }

        private static void Print(float value)
        {
            Console.WriteLine($"Дробное число: {value:F3}");
        }

        private static void Print(IReadOnlyList<int> array)
        {
            string result = "";
            foreach (int i in array)
            {
                result += i + " ";
            }
            Console.WriteLine($"Массив целых чисел: {result}");
        }

        private static void Print(IReadOnlyList<float> array)
        {
            string result = "";
            foreach (float i in array)
            {
                result += ($"{i:F3} ");
            }
            Console.WriteLine($"Массив дробных чисел с округлением до 3го знака: {result}");
        }

        private static void SetValues(out int x, out float y)
        {
            x = GetInt();
            y = GetFloat();
        }

        private static void SetArray(out float[] b)
        {
            Random random = new Random();
            b = new float[GetArraySize()];
            for (uint i = 0; i < b.Length; i++)
            {
                b[i] = (float)(random.Next(1941) + random.NextDouble());
            }
        }

        private static void SetArray(out int[] a)
        {
            Random random = new Random(100);
            a = new int[GetArraySize()];
            for (uint i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(1945);
            }
        }

        private static uint GetArraySize()
        {
            Console.WriteLine("Введите размер массива:");
            uint value;
            return uint.TryParse(Console.ReadLine(), out value) ? value : 0;
        }

        private static void Main()
        {
            int x;
            float y;
            int[] a;
            float[] b;

            SetValues(out x, out y);
            Print(x);
            Print(y);

            SetArray(out a);
            SetArray(out b);
            Print(a);
            Print(b);

            Console.ReadKey();
        }
    }
}
