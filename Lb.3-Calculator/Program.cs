using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb._3_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.x = 153;
            calculator.y = 123;
            calculator.Plus(calculator.x, calculator.y);

            calculator.x = 123;
            calculator.y = 233;
            calculator.Plus(calculator.x, calculator.y);

            calculator.x = 123.123;
            calculator.y = 123;
            calculator.Minus(calculator.x, calculator.y);

            calculator.x = 654;
            calculator.y = 23;
            calculator.Minus(calculator.x, calculator.y);

            calculator.x = 234;
            calculator.y = 34;
            calculator.Minus(calculator.x, calculator.y);

            calculator.x = 23;
            calculator.y = 23;
            calculator.Minus(calculator.x, calculator.y);

            calculator.x = 66;
            calculator.y = 33;
            calculator.Mult(calculator.x, calculator.y);

            calculator.x = 44;
            calculator.y = 44;
            calculator.Mult(calculator.x, calculator.y);

            calculator.x = 55;
            calculator.y = 76;
            calculator.Mult(calculator.x, calculator.y);

            calculator.x = 77;
            calculator.y = 66;
            calculator.Mult(calculator.x, calculator.y);


            Console.WriteLine("Инструкция: сначала Вам нужно ввести первое число, затем второе, затем операцию.\nЕсли вы введёте не число, или операцию не из списка, программа известит Вас об этом. ");
            Console.WriteLine("Что бы закончить работу, нужно закрыть консоль.");
            int a = 1;
            while (a > 0)
            {

                Console.WriteLine("Введите первое число: ");
                string num1 = Console.ReadLine();
                if (num1.Any(q => char.IsLetter(q)) || string.IsNullOrEmpty(num1))
                { 
                    Console.WriteLine("Ошибка, вы ввели не число!");
                    continue;
                }
                else
                {
                    calculator.x = int.Parse(num1);
                }

                int b = 1;
                while (b > 0)
                {
                    Console.WriteLine("Введите второе число: ");
                    string num2 = Console.ReadLine();
                    if (num2.Any(q => char.IsLetter(q)) || string.IsNullOrEmpty(num2))
                    {
                        Console.WriteLine("Ошибка, вы ввели не число!");
                        continue;
                    }
                    else
                    {
                        calculator.y = int.Parse(num2);
                        b -= 1;
                    }
                }

                int c = 1;
                while (c > 0)
                {

                    Console.WriteLine("Введите операцию(+, -, *): ");
                    string operation = Console.ReadLine();
                    if (operation == "+")
                    {
                        calculator.Plus(calculator.x, calculator.y);
                        c -= 1;
                    }

                    else if (operation == "-")
                    {
                        calculator.Minus(calculator.x, calculator.y);
                        c -= 1;
                    }
                    else if (operation == "*")
                    {
                        calculator.Mult(calculator.x, calculator.y);
                        c -= 1;
                    }
                    else
                        Console.WriteLine("Вы ввели не операцию не из списка!");
                    Console.WriteLine();
                }
            }
        }
    }
}
