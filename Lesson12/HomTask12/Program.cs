using System;
using System.Linq;

namespace HomeTask12
{
    class Program
    {
        static void Main()
        {
            // Создать коллекцию из 100 случайных дробей. Выбрать все дроби, которые являются целым числом. 
            // Вывести на консоль их как целые числа.
            try
            {
                Random random = new Random();

                var fractions = Enumerable.Range(0, 100)
                    .Select(f => new SimpleFraction(random.Next(30), random.Next(1, 30)))
                    .Where(f => f.Numerator % f.Denominator == 0)
                    .Select(f => new
                    {
                        fraction = f.ToString(),
                        fractionInt = f.Numerator / f.Denominator
                    });

                Console.WriteLine("Целое число, дробь:");

                foreach (var numb in fractions)
                {
                    Console.Write($"{numb.fractionInt} , ");
                    Console.WriteLine($"{numb.fraction}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
