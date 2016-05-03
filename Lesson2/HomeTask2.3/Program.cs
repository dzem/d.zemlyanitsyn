using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Калькулятор. С консоли вводится левый операнд, операция, правый операнд. 
            //Выводится результат операции над операндами. Реализовать как минимум 4 операции, обработку ошибок (деление на 0 и др).

            double op1;
            double op2;
            double result = 0;
            char operation;
            char[] operations = { '+', '-', '*', '/', '^' };

            Console.WriteLine("Введите первый операнд:");
            if (!Double.TryParse(Console.ReadLine(), out op1))
            {
                Console.WriteLine("Некорректный операнд");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите один из операторов (+, -, *, /, ^):");
            Char.TryParse(Console.ReadLine(), out operation);
            if (!operations.Contains(operation))
            {
                Console.WriteLine("Некорректный оператор");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите второй операнд:");
            if (!Double.TryParse(Console.ReadLine(), out op2))
            {
                Console.WriteLine("Некорректный операнд");
                Console.ReadKey();
                return;
            }

            switch (operation)
            {
                case '+':
                    result = op1 + op2;
                    break;
                case '-':
                    result = op1 - op2;
                    break;
                case '*':
                    result = op1 * op2;
                    break;
                case '/':
                    if (op2 == 0)
                    {
                        Console.WriteLine("Деление на ноль. До уничтожения Земли осталось 3 ... 2 ...");
                        Console.ReadKey();
                        return;
                    }
                    else
                    {
                        result = op1 / op2;
                    }
                    break;    
                case '^':
                    result = Math.Pow(op1,op2);
                    break;
            }

            Console.WriteLine("Результат операции {0} {1} {2} = {3}", op1 , operation, op2, result);
            Console.ReadKey();
        }
    }
}
