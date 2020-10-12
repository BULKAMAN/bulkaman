using System;
using System.Collections.Generic;
using System.Text;

namespace Terminal
{
    class Calculator
    {
        public void clCulator()
        {
            Console.WriteLine("Консольный калькулятор (версия 1.0)");
            Console.WriteLine(' ');
            Console.WriteLine(@"Выберите арифметическое действие:
            - Умножение (введите 1)
            - Деление (введите 2)
            - Сложение (введите 3)
            - Вычитание (введите 4)
            - Возведение числа в степень (введите 5)");
            string q = Console.ReadLine();
            double a, b;
            Console.WriteLine(' ');
            Console.WriteLine("Введите первое значение");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе значение");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine(' ');
            if (q == "1")
            {
                Console.WriteLine("Результат умножения = {0}", a * b);
            }
            if (q == "2")
            {
                Console.WriteLine("Результат деления = {0}", a / b);
            }
            if (q == "3")
            {
                Console.WriteLine("Результат сложения = {0}", a + b);
            }
            if (q == "4")
            {
                Console.WriteLine("Результат вычитания = {0}", a - b);
            }
            if (q == "5")
            {
                Console.WriteLine("Результат возведения числа в степень = {0}", Math.Pow(a, b));
            }
        }
    }
}
