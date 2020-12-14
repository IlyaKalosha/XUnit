using System;
using System.Collections.Generic;

namespace XUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int key = -10000;
            double firstValue = 0;
            double secondValue = 0;
            double result = 0;

            do
            {
                while (true)
                {
                    Console.WriteLine("Выберите операцию:");
                    Console.WriteLine("1 - Сложение");
                    Console.WriteLine("2 - Вычитание");
                    Console.WriteLine("3 - Умножение");
                    Console.WriteLine("4 - Деление");
                    Console.WriteLine("5 - Остаток от деления");
                    Console.WriteLine("6 - Возведение в степень");
                    Console.WriteLine("0 - Выход");

                    try
                    {
                        key = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter NUMBER [0; 6]");

                    }
                    catch (ArgumentNullException)
                    {
                        Console.WriteLine("Enter NOT NULL value");
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Enter NUMBER [0; 6]");
                    }
                }
                if (key == 0)
                {
                    break;
                }
                while (true)
                {
                    Console.WriteLine("Введите первое значение");
                    try
                    {
                        firstValue = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter NUMBER [0; 6]");

                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Enter NUMBER [-1.79769313486232e308; 1.79769313486232e308]");
                    }
                }

                while (true)
                {
                    Console.WriteLine("Введите второе значение");
                    try
                    {
                        secondValue = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter NUMBER [0; 6]");

                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Enter NUMBER [-1.79769313486232e308; 1.79769313486232e308]");
                    }
                }

                try
                {
                    result = calculator.culcFunctions[key].Invoke(firstValue, secondValue);
                    Console.WriteLine("Результат: " + result.ToString());
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("На ноль делить нельзя");
                }

            } while (key != 0);
        }
    }
}
