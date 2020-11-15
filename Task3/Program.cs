using System;

/*
 * На вход подаются три числа: параметры функции a, b, c
 * Протабулировать функцию y на x \in [1;2] с шагом ∆𝑥 = 0,05
 *
 *      ax^2 + bx + c,              x < 1,2
 * y =  a/x + sqrt(x^2 + 1),        x = 1,2
 *      (a + bx) / sqrt(x^2 + 1),   x > 1,2
 *
 * Пример входных данных:
 * 1
 * 2
 * 3
 *
 * Пример выходных данных:
 * 6
 * 6,203
 * 6,41
 * 6,623
 * 2,395
 * 2,186
 * 2,195
 * 2,202
 * 2,209
 * 2,214
 * 2,219
 * 2,223
 * 2,226
 * 2,229
 * 2,231
 * 2,233
 * 2,234
 * 2,235
 * 2,236
 * 2,236
 * 2,236
 * Примечание: 
 *      При некорректных входных данных вывести сообщение "Ошибка" и завершить выполнение программы.
 *      Вывод чисел необходимо производить с точностью до трех знаков после запятой.
 */
namespace Task3
{
    class Program
    {
        // TODO: самостоятельно выделите и напишите методы, использующиеся для решения задачи
        static double G(double a, double b, double c, double x)
        {
            if (x < 1.2)
            {
                return a * x * x + b * x + c;
            }
            else if(x == 1.2)
            {
                return a / x + Math.Sqrt(x * x - 1);
            }
            else
            {
                return (a + b * x) / Math.Sqrt(x * x + 1);
            }
        }

        static void Main(string[] args)
        {
            bool check = true;
            double a, b, c;
            check &= double.TryParse(Console.ReadLine(), out a);
            check &= double.TryParse(Console.ReadLine(), out b);
            check &= double.TryParse(Console.ReadLine(), out c);

            for (double i = 1; i <= 2; i+= 0.05)
            {
                Console.WriteLine($"{G(a,b,c,i):f3}");
            }
        }
    }
}