using System;

/*
 * Пользователь вводит неотрицательные целые (int) числа q и p, такие, что q <= p.
 * Определить все тройки попарно различных целых чисел a, b, c \in [q; p],
 * для которых верно a^2 + b^2 = c^2.
 *
 * Пример входных данных:
 * 1
 * 10
 *
 * Пример выходных данных:
 * 3 4 5
 * 6 8 10
 *
 * Примечание:
 *      Тройки необходимо выводить в алфавитном порядке, то есть по возрастанию чисел в них.
 *      При некорректных входных данных вывести сообщение "Ошибка" и завершить выполнение программы.
 *      Разрешается модифицировать предложенные методы и дополнять программу своими при необходимости.
 */

namespace Task1
{
    class Program
    {

        // TODO: использовать передачу параметров по ссылке
        static void ReadBoundaries(out int left, out int right, out bool correct)
        {
            // TODO: прочитать границы и проверить введенные данные на корректность
            correct = int.TryParse(Console.ReadLine(), out left) && left >= 0;
            correct &= int.TryParse(Console.ReadLine(), out right) && right >= 0 && right > left;
        }

        static void PrintPythagorasNumbers(int left, int right)
        {
            // TODO: вывести пифагоровы тройки с числами из введенного отрезка
            for (int a = left; a <= right; a++)
            {
                for (int b = a + 1; b <= right; a++)
                {
                    if (a * a + b * b == c * c)
                    {
                        Console.WriteLine($"{a} {b} {c}");
                    }

                }
            }
        }

        static void Main(string[] args)
        {
            int left, right;
            bool correct;
            // TODO: дополнить метод так, чтобы программа выполняла поставленную задачу
            ReadBoundaries(out left, out right, out correct);
            if (correct)
            {
                PrintPythagorasNumbers(left, right);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}