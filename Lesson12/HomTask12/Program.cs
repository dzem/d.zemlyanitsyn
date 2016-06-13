using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeTask12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создать коллекцию из 100 случайных дробей. Выбрать все дроби, которые являются целым числом. 
            // Вывести на консоль их как целые числа.
            try
            {
                Random random = new Random();

                List<SimpleFraction> fractions = new List<SimpleFraction>();
                for (int i=0; i <= 100; i++)
                {
                    fractions.Add(new SimpleFraction(random.Next(30), random.Next(1, 30)));
                }

                var ints = fractions.Where(f => f.Numerator % f.Denominator == 0)
                    .Select(f => new
                    {
                        fractionInt = f.Numerator / f.Denominator
                    });

                Console.WriteLine("Целые числа:");

                foreach(var numb in ints)
                {
                    Console.Write($"{numb.fractionInt} ");
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
