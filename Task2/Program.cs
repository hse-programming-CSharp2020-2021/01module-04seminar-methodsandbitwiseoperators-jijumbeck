﻿using System;

/*
 * Пользователь последовательно вводит целые числа.
 * Для хранения полученных чисел в программе используется одна переменная.
 * Окончание ввода чисел определяется либо желанием пользователя (ввод строки "q"),
 * либо когда сумма уже введённых отрицательных чисел становится меньше -1000.
 * Определить и вывести на экран среднее арифметическое отрицательных чисел.
 *
 * Пример входных данных:
 *  1
 *  3
 *  -4
 *  2
 *  -3
 *  q
 *
 * Пример выходных данных:
 * -3.5
 *
 * Примечание:
 *      При некорректном вводе вывести сообщение "Ошибка" и завершить выполнение программы.
 *      Разрешается модифицировать предложенные методы и дополнять программу своими при необходимости.
 *      Вывод чисел необходимо производить с точностью до двух знаков после запятой.
 */

namespace Task2
{
    class Program
    {
        // TODO: используйте передачу параметров по ссылке
        static public void ReadData(out double sum, out bool check)
        {
            string str = "";
            check = true;
            sum = 0;
            int x;
            int count = 0;
            while (str != "q" && sum > -1000)
            {
                str = Console.ReadLine();
                check &= int.TryParse(str, out x);
                if(x < 0 && check)
                {
                    sum += x;
                    count += 1;
                }
                
            }
            if (check)
            {
                sum = sum / count;
            }
        }


        static void Main(string[] args)
        {
            double arifm;
            bool check;
            ReadData(out arifm, out check);

            if (!check)
            {
                Console.WriteLine("Ошибка");
            }
            else
            {
                Console.WriteLine($"{arifm:f2}");
            }

            
        }
    }
}