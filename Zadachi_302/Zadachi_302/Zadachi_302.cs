using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadachi_302
{
    // Семакин 302 с. Задачи на составление логических выражений 
    /* Составить линейные программу, 
     * печатающую значение true, если указанное высказывание является истинным, 
     * и false — в противном случае.
     */
    class Zadachi_302
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Zadacha_1());
            Console.WriteLine();
            Console.WriteLine(Zadacha_2());
            Console.WriteLine();
            Console.WriteLine(Zadacha_8());
            Console.WriteLine();
            Console.WriteLine(Zadacha_11());
            Console.ReadKey();
        }

        /* Задача 1 303с.
         * Сумма двух первых цифр заданного четырехзначного числа равна сумме двух его последних цифр.
         */
        public static string Zadacha_1()
        {
            Console.WriteLine("Введите четырехзначное число");
            int x;
            string s = Console.ReadLine();
            if (int.TryParse(s, out x) && s.Length == 4)
            {
                int firstSum = s[0] + s[1];
                int secSum = s[2] + s[3];
                if (firstSum == secSum) return "true";
                else return "false";
            }
            else return "Введенный елемент не удовлетворяет условия задачи";
        }

        /* Задача 2 303с. 
         * Сумма цифр данного трехзначного числа N является четным числом.
         */
        public static string Zadacha_2()
        {
            Console.WriteLine("Введите трехзначное число");
            int x;
            string s = Console.ReadLine();
            if (int.TryParse(s, out x) && s.Length == 3)
            {
                int firstSum = x/100 + x/10%10 + x%10;
                Console.WriteLine(firstSum);
                if (firstSum % 2 == 0) return "true";
                else return "false";
            }
            else return "Введенный елемент не удовлетворяет условия задачи";
        }

        /* Задача 8 303с. 
         * Среди чисел а, Ь, с есть хотя бы одна пара взаимно противоположных.
         */
        public static bool Zadacha_8()
        {
            double a, b, c;
            Console.WriteLine("Введите число а: ");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Введите число b: ");
            double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Введите число c: ");
            double.TryParse(Console.ReadLine(), out c);

            if ((a == -b) || (a == -c) || (b == -c)) return true;
            else return false;
        }

        /* Задача 11 303с. 
         * Данная тройка натуральных чисел а, Ь, с является тройкой Пифагора, т.е. с^2= а^2+ Ь^2.
         */
        public static bool Zadacha_11()
        {
            double a, b, c;
            Console.WriteLine("Введите число а: ");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Введите число b: ");
            double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Введите число c: ");
            double.TryParse(Console.ReadLine(), out c);

            if ((a * a == b * b + c * c) || (b * b == a * a + c * c) || (c * c == b * b + a * a)) return true;
            else return false;
        }
    }


}
