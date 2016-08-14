using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_14_300
{
    /* Семакин страница 300 задача № 14: 
     * Вычислить корни квадратного уравнения ах*x+ Ьх + с = 0 с заданными коэффициентами a, b и с 
     * (предполагается, что а != 0 и что дискриминант уравнения неотрицателен).
     * 
     * Сделаем интересней упустим уточнение в скобках
     * В работе используем класс Math.
     */

    class Zadacha_14_300
    {
        static void Main(string[] args)
        {
            // Обьявили переменные 
            double a, b, c, x, x1, x2, d;

            // Ввод данных с консоли
            Console.WriteLine("Введите коефициент a квадратного уравнения");
            a = Entry();
            Console.WriteLine("Введите коефициент b квадратного уравнения");
            b = Entry();
            Console.WriteLine("Введите коефициент c квадратного уравнения");
            c = Entry();

            Console.WriteLine();

            // Условия равенства а нулю и 2 ветки развития событий
            if (a == 0)
            {
                Console.WriteLine("Коефициент а равен 0! Уравнение превращается в линейное");
                x = -(c / b);
                Console.WriteLine("Корень как оказалось простого уравнения x: {0:0.##}", x);
            }
            else
            {
                // Вычисление дискриминанта
                d = b * b - 4 * a * c;

                // Ветвление для дальнейшего расчета корней квадратного уравнения
                if (d < 0) Console.WriteLine("Действетельных корней квадратного уравнения не существует \n Комплексно-сопряженные не считаем");
                else if (d == 0)
                {
                    x = -b / (2 * a);
                    Console.WriteLine("Корень квадратного уравнения x: {0:0.##}", x);
                }
                else
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("Первый корень квадратного уравнения x1: {0:0.##}", x1);
                    Console.WriteLine("Второй корень квадратного уравнения x1: {0:0.##}", x2);
                }
            }

            Console.ReadKey();
        }
            public static double Entry()
            {
                double cof;
                while (true)
                {
                    if (!double.TryParse(Console.ReadLine(), out cof)) 
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Некоректный ввод повториет попытку");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else break;
                }
                return cof;
            }    
    }
}
