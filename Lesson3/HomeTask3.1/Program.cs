using System;
using System.Collections.Generic;

namespace HomeTask3._1
{
    class Program
    {
        //Считать строку с консоли.Создать словарь, где ключом будет символ строки, 
        //а значением - количество данных символов в считанной строке.

        private static string GetString()
        {
            Console.WriteLine("Введите строку:");
            return Console.ReadLine();
        }

        private static Dictionary<char, int> FillDictionary(string str)
        {
            int i = 1;
            Dictionary<char, int> symbols = new Dictionary<char, int>();
            foreach (char symbol in str)
            {
                if (symbols.ContainsKey(symbol))
                {
                    symbols[symbol]++;
                }
                else
                {
                    symbols.Add(symbol, i);
                }
            }
            return symbols;
        }

        private static void PrintDictionary(Dictionary<char, int> dict)
        {
            foreach (var symbol in dict)
            {
                Console.WriteLine($"Количество символов {symbol.Key} : {symbol.Value} ");
            }
        }

        private static void Main()
        {
            Dictionary<char, int> symbols = FillDictionary(GetString());
            PrintDictionary(symbols);
            Console.ReadKey();
        }
    }
}
