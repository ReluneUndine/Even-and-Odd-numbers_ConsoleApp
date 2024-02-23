using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_and_Odd_numbers_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args) // Точка входа, начало кода
        {
            Console.WriteLine("Приложение по определению чётного или нечётного числа");

            for (; ; ) // использую бесконечный цикл (без счетчика), чтобы игра никогда не заканчивалась
            {
                Console.WriteLine("\n\n Пожалуйста, введите целое число: "); // использую вместе с WriteLine дополнительный перенос строк \n\n (увеличиваю расстояние)
                int integer = Convert.ToInt32(Console.ReadLine()); // конвертирую введенное пользователем строковое значение -> в числовое

                if (integer % 2 == 0) // использую оператор деления с остатком %, чтобы понять, четное число или нет
                {
                    Console.Write($"{integer} - это чётное число.");
                }
                else
                {
                    Console.Write($"{integer} - это нечётное число.");
                }
                Console.ReadKey();
            }

        }
    }
}
