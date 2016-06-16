using System;
using System.Linq;

namespace Lesson12
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();

            var ints = Enumerable.Range(0, 10)
                .Select(i => random.Next(30))
                .Where(i => i%2 == 0 || i > 5)
                .OrderByDescending(i => i)
                .Where(i =>
                {
                    Console.WriteLine(i);
                    return true;
                })
                .ToArray();

            Console.ReadKey();
        }
    }
}
