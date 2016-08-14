using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadachi_311
{
    /* Cемакин задачи 1, 6, 7, 8, 13 страница 311
     */
    class Zadachi_311
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Zadacha_1(5, -2, 3));
            Console.WriteLine();
            Console.WriteLine(Zadacha_6(4, 4));
            Console.WriteLine(Zadacha_6(2, 4));
            Console.WriteLine(Zadacha_6(9, 1));
            Console.WriteLine();
            Console.WriteLine("Количество отрицательных значений: " + Zadacha_7(4,-1,-2));
            Console.WriteLine();
            Console.WriteLine("Количество положительных значений: " + Zadacha_8(4, -1, -2));
            Console.WriteLine();
            Console.WriteLine(Zadacha_13(60,75,2,1));
            Console.WriteLine(Zadacha_13(25, 75, 2, 4));
            Console.WriteLine(Zadacha_13(50, 75, 1, 2));
            Console.ReadKey();
        }

        /* 1. Даны три действительных числа. 
         * Возвести в квадрат те из них, значения которых неотрицательны, 
         * и в четвертую степень — отрицательные.
         */
        public static string Zadacha_1(double a,double b,double c)
        {
            a = MethodZadacha_1(a);
            b = MethodZadacha_1(b);
            c = MethodZadacha_1(c);

            return string.Format("a: {0}, b: {1}, c: {2}", a, b, c);
        }

        public static double MethodZadacha_1(double el)
        {
            if (el >= 0) el = Math.Pow(el, 2);
            else el = Math.Pow(el, 4);
            return el;
        }

        /* 6. Даны целые числа m,n. Если числа не равны, то заменить
         * каждое из них одним и тем же числом, равным большему из исходных,
         * а если равны, то заменить числа нулями.
         */
        public static string Zadacha_6(int m,int n)
        {
            if (m == n)
            {
                m = 0;
                n = 0;
            }
            else
            {
                if (m > n) n = m;
                else m = n;
            }

            return string.Format("m: {0}, n: {1}", m,n);
        }

        /* 7. Подсчитать количество отрицательных среди чисел а, Ь, с.
         */
        public static int Zadacha_7(double a, double b, double c)
        {
            int count = 0;

            if (a < 0) count++;
            if (b < 0) count++;
            if (c < 0) count++;

            return count;
        }

        /* 8. Подсчитать количество положительных среди чисел а, Ь, с.
         */
        public static int Zadacha_8(double a, double b, double c)
        {
            int count = 0;

            if (a > 0) count++;
            if (b > 0) count++;
            if (c > 0) count++;

            return count;
        }

        /* 13. Грузовой автомобиль выехал из одного города в другой со
         * скоростью v1 км/ч. Через (t1 ч в этом же направлении выехал легковой
         * автомобиль со скоростью v2 км/ч. Составить программу, определяющую,
         * догонит ли легковой автомобиль грузовой через t2, ч после своего выезда.
         */
        public static string Zadacha_13(double v1, double v2, double t1, double t2)
        {
            if (v1 * (t1 + t2) > v2 * t2)
                return string.Format("До грузовика остается {0} км. Не догнал(", (v1 * (t1 + t2)) - (v2 * t2));
            else if (v1 * (t1 + t2) == v2 * t2)
                return string.Format("Догнал! Идут паралельно");
            else
                return string.Format("Перегнал грузовик на {0} км!", (v2 * t2)-(v1 * (t1 + t2)));
        }
    }
}
