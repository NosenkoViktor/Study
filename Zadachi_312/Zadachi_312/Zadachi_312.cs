using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadachi_312
{
    /* Семакин задачи стр 312 */
    class Zadachi_312
    {
        static void Main(string[] args)
        {
            Console.WriteLine("№ 1. Cумма большего и меньшего елементов: {0}", Zadacha_1(-12, 2, 8));
            Console.WriteLine("№ 3. max(min(а, b), min(c, d)) : {0}", Zadacha_3(-12, 2, 8, -10));
            Console.WriteLine();
            Zadacha_13(-12);
            Console.WriteLine();
            Zadacha_13(278);
            Console.WriteLine();
            Zadacha_17(125,322);
            Zadacha_17(125, 301);
            Console.ReadKey();
        }

        /* 1. Написать программу нахождения суммы большего и меньшего из трех чисел.
         */
        public static double Zadacha_1(double a, double b, double c)
        {
            List<double> list = new List<double> { a, b, c };
            list.Sort();
            double res = list[0] + list[list.Count-1];
            return res;
        }

        /* 3. Найти max{min(а, b), min(c, d)}.
         * Как я понял есть 4 числа a,b,c,d нужно найти максимальное число из чисел которые минимальны в парах a,b и c,d
         */

        public static double Zadacha_3(double a, double b, double c, double d)
        {
            double res = Math.Max(Math.Min(a, b), Math.Min(c, d));
            return res;
        }

        /* 13. Дано число х. Напечатать в порядке возрастания числа: sinx, cosx, lnx. Если при каком-либо х некоторые из выражений не
         * имеют смысла, вывести сообщение об этом и сравнивать значения только тех, которые имеют смысл.
         */
        public static void Zadacha_13(double x)
        {
            Console.WriteLine("№ 13. sin(x), cos(x), ln(x) для числа {0} в порядке возростания", x);
            List<double> list = new List<double>();
            if (x <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Натуральный логарифм чисел меньше равных нулю лежит в комплексной области");
                Console.WriteLine("ln({0}) = ln({1})+i*PI", x, -x);
                Console.ForegroundColor = ConsoleColor.Gray;
                list.Add(Math.Sin(x));
                list.Add(Math.Cos(x));
            }
            else
            {
                list.Add(Math.Log(x));
                list.Add(Math.Sin(x));
                list.Add(Math.Cos(x));
            }
            list.Sort();

            int count = 1;
            foreach (double d in list)
            {
                Console.WriteLine("{0}.  {1:0.####}", count++, d);
            }
        }


        /* 17. В небоскребе N этажей и всего один подъезд; на каждом этаже по 3 квартиры; лифт может останавливаться только на
         * нечетных этажах. Человек садится в лифт и набирает номер нужной ему квартиры М. На какой этаж должен доставить лифт пассажира?
         * 
         * Тут как по мне не совсем коректно поставлена задача.
         * Если лифт останавливается на нечетных етажах а человек живет на четном то лифт должен давать выбор 
         * поднятся выше от этажа где живет человек или остановится на етаж ниже
         */
        public static void Zadacha_17(int n, int m)
        {
            if (n * 3 < m) Console.WriteLine("Квартиры с таким номером не существует в доме");
            else
            {
                int count = -1, flor;

                // Находим количество этажей которое остается до верхушки дома
                for (int i = n*3; i >= m; i -= 3) count++;

                // Находим этаж где живет человек
                flor = n - count;
                if (flor % 2 == 0)
                {
                    Console.WriteLine("Человеку можно втсать на {0} и поднятся на 1 этаж пешком", flor - 1);
                    Console.WriteLine("Или можно втсать на {0} и спустится на 1 этаж пешком", flor + 1);
                }
                else Console.WriteLine("Человек живет на {0} этаже куда его и доставит лифт",flor);
            }
        }
    }
}
