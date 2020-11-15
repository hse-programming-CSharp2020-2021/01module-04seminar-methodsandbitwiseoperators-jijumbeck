using System;

/*
 * Вычислить значение выражения 2^𝑁+2^𝑀, 𝑁, 𝑀 – целые неотрицательные числа вводятся пользователем с клавиатуры.
 * Используйте битовые операции для организации «быстрого умножения». Помните о возможности переполнения
 *
 * Пример входных данных:
 * 2
 * 4
 *
 * Пример выходных данных:
 * 20
 *
 * Примечание:
 *      При некорректных входных данных вывести сообщение "Ошибка" и завершить выполнение программы.
 *      При переполнении вывести сообщение "Переполнение".
 */

namespace Task4
{
    class Program
    {
        // TODO: самостоятельно выделите и напишите методы, использующиеся для решения задачи

        static double myPow(double x, int pow)
        {
            // TODO : Реализовать быстрое возведение в степень.
            if (pow == 0)
            {
                return 1;
            }
            else if (pow % 2 == 0)
            {
                double g = myPow(x, pow / 2);
                return g * g;
            }
            else
            {
                return x * myPow(x, pow - 1);
            }
        }

        static void Main(string[] args)
        {
            try
            {
                int n, m;
                bool check = true;
                check &= int.TryParse(Console.ReadLine(), out n) && n >= 0;
                check &= int.TryParse(Console.ReadLine(), out m) && m >= 0;
                if (!check)
                {
                    Console.WriteLine("Ошибка");
                }
                else
                {
                    Console.WriteLine(myPow(2,n) + myPow(2,m));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Переполнение");
            }
        }
    }
}