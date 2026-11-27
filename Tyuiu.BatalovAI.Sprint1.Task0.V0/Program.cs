using System;
using Tyuiu.BatalovAI.Sprint1.Task0.V0.Lib;

//ЗАДАНИЕ
//Написать программу, которая вычисляет выражение 10 / (2 + 3) и печатает результат на экране.

namespace Tyuiu.BatalovAI.Sprint1.Task0.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Баталов А. | ИСПб-26-1                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 10 / (2 + 3)            *");
            Console.WriteLine("* и печатает результат на экране.                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("* Выражение: 10 / (2 + 3)                                                 *");
            Console.WriteLine("***************************************************************************");

            double result = ds.Calculate();

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Результат выражения 10 / (2 + 3) = {result}");
            Console.WriteLine("***************************************************************************");

            Console.ReadLine();
        }
    }
}