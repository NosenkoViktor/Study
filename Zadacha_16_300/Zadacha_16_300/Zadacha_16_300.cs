using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadacha_16_300
{
    /* Семакин задача 16 300 с.
     * Дано значение х. Получить значения — 2x + 3x^2 - 4x^3 и 1 + 2х + Зх^2 + 4х^3. Позаботиться об экономии операций.
     * 
     * Если я правильно понял "Позаботиться об экономии операций" это свести выполнения 2-х уравнений в один метод.
     * То есть свести к минимуму количество операций в методе Main.
     */
    class Zadacha_16_300
    {
        static void Main(string[] args)
        {
            double res1, res2;
            Zadacha_16_300.Operation(1.45, out res1, out res2);
            Console.WriteLine("Результат первого вычисления: {0:0.##} \nРезультат второго вычисления: {1:0.##}", res1, res2);
            Console.ReadKey();
        }

        public static void Operation(double x, out double result1, out double result2)
        {
            double a = 3 * Math.Pow(x, 2), b = 4 * Math.Pow(x, 3), c = 2 * x;
            result1 = - c + a - b;
            result2 = 1 + c + a + b;
        }
    }
}
