using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadachi_298
{
    class Equation
    {
        // Задачи 1-28 Семакин 298 - 299 с.
        // Незнаю как тебе лучше проверять по результирующему значению или по формуле, по этому сделал в 2-х вариантах
        // Также написал для каждого примера свой статический метод

        static void Main(string[] args)
        {
            double a=1.0, b=2.0, c=3.0, d=4.0, f=5.0, x=6.0, y=7.0, z=8.0;
             
             //Пример 1
            double solution_1 = (b + Math.Sqrt(Math.Pow(b, 2) + 4 * a * c)) / (2 * a) + Math.Pow(a, 3) * c + Math.Pow(b, -2);

             //Пример 2
            double solution_2 = ((a / c) * (b / d)) - ((a * b - c) / (c * d));

             //Пример 3
            double solution_3 = ((Math.Sin(x) + Math.Cos(y)) / (Math.Cos(x) - Math.Sin(y))) * Math.Tan(x * y);

             //Пример 4
            double solution_4 = ((x + y) / (y + 1)) - ((x * y - 12) / (34 + x));

             //Пример 5
            double solution_5 = (3 + Math.Exp(y - 1)) / (1 + Math.Pow(x, 2) * Math.Abs(y - Math.Tan(y)));

             //Пример 6
            double solution_6 = x - (Math.Pow(x, 3) / 3) + (Math.Pow(x, 5) / 5);

             //Пример 7
            double solution_7 = Math.Log(Math.Abs((y - Math.Sqrt(Math.Abs(x))) * (x - y / (x + Math.Pow(x, 2) / 4))));

             //Пример 8
            double solution_8 = Math.Pow((1 - Math.Tan(x)), 1 / Math.Tan(x)) + Math.Cos(x - y);

             //Пример 9
            double solution_9 = Math.Log(Math.Abs(Math.Cos(x))) / Math.Log(1 + Math.Pow(x, 2));

             //Пример 10
            double solution_10 = Math.Pow(((x + 1) / (x - 1)), x) + 18 * x * Math.Pow(y, 2);

             //Пример 11
            double solution_11 = Math.Pow((1 + (1 / Math.Pow(x, 2))), x) + 12 * Math.Pow(x, 2) * y;

             //Пример 12
            double solution_12 = (x * x - 7 * x - 10) / (x * x - 8 * x + 12);

             //Пример 13
            double solution_13 = (Math.Cos(x) / (Math.PI - 2 * x)) + 16 * x * Math.Cos(x * y) - 2;

             //Пример 14
            double solution_14 = Math.Pow(2, -x) - Math.Cos(x) + Math.Sin(2 * x * y);

             //Пример 15
            double solution_15 = 2 * (1 / Math.Tan(3 * x)) - (1 / (12 * x * x + 7 * x - 5));

             //Пример 16
            double solution_16 = Math.Abs(Math.Pow(x, 2) - Math.Pow(x, 3)) - (7 * x) / (Math.Pow(x, 3) - 15 * x);

             //Пример 17
            double solution_17 = x * Math.Log(x) + (y / (Math.Cos(x) - (x / 3)));

             //Пример 18
            double solution_18 = Math.Sin(Math.Sqrt(x + 1)) - Math.Sin(Math.Sqrt(x - 1));

             //Пример 19
            double solution_19 = Math.Exp(x) - (y * y + 12 * x * y - 3 * x * x) / (18 * y - 1);

             //Пример 20
            double solution_20 = (1 + Math.Sin(Math.Sqrt(x + 1))) / (Math.Cos(12 * y - 4));

             //Пример 21
            double solution_21 = 2 * (1 / Math.Tan(3 * x)) - (Math.Log(Math.Cos(x))) / (Math.Log(1 + x * x));

             //Пример 22
            double solution_22 = Math.Exp(x) - x - 2 + Math.Pow((1 + x), x);

             //Пример 23
            double solution_23 = Math.Pow(3, x) - 4 * x + (y - Math.Sqrt(Math.Abs(x)));

             //Пример 24
            double solution_24 = x - 10 * Math.Sin(x) + Math.Abs(Math.Pow(x, 4) - Math.Pow(x, 5));

             //Пример 25
            double solution_25 = x - Math.Pow(10, Math.Sin(x)) + Math.Cos(x - y);

             //Пример 26
            double solution_26 = (1 + Math.Pow(Math.Sin(x + y), 2)) / (2 + Math.Abs(x - (2 * x) / (1 + x * x * y * y))) + x;

             //Пример 27
            double solution_27 = Math.Pow(Math.Cos(Math.Sin(1 / z)), 2);

             //Пример 28
            double solution_28 = (Math.Pow(Math.Cos(x), 2) / Math.Sin(x)) - x * y * z + (a * x * x + b * x + c) / (d * Math.Pow(x, 3) - f);



            double[] array = new double[28] {
                    Equation.Primer_1(1, 2, 3),
                    Equation.Primer_2(1, 2, 3, 4.25),
                    Equation.Primer_3(1, 2),
                    Equation.Primer_4(1, 2),
                    Equation.Primer_5(1, 2),
                    Equation.Primer_6(10),
                    Equation.Primer_7(1, 25),
                    Equation.Primer_8(90, 0),
                    Equation.Primer_9(10),
                    Equation.Primer_10(10, -4),
                    Equation.Primer_11(1, 2),
                    Equation.Primer_12(10),
                    Equation.Primer_13(1, 2),
                    Equation.Primer_14(1, 2),
                    Equation.Primer_15(10),
                    Equation.Primer_16(10),
                    Equation.Primer_17(1, 2),
                    Equation.Primer_18(10),
                    Equation.Primer_19(1, 2),
                    Equation.Primer_20(1, 2),
                    Equation.Primer_21(-5),
                    Equation.Primer_22(10),
                    Equation.Primer_23(1, 23),
                    Equation.Primer_24(10),
                    Equation.Primer_25(1, 2),
                    Equation.Primer_26(1, 2),
                    Equation.Primer_27(1, 3),
                    Equation.Primer_28(1, 2, 3, 4, 5, 6, 7, 8)};

            for (int i=0; i<array.Length; i++)
            {
                Console.WriteLine("Пример № {0} ответ: {1:0.####}", i+1, array[i]);
            }

            Console.ReadKey();

        }

        public static double Primer_1(double a, double b, double c)
        {
            double result;
            result = (b + Math.Sqrt(Math.Pow(b, 2) + 4 * a * c)) / (2 * a) + Math.Pow(a, 3) * c + Math.Pow(b, -2);
            return result;
        }

        public static double Primer_2(double a, double b, double c, double d)
        {
            double result;
            result = ((a / c) * (b / d)) - ((a * b - c) / (c * d));
            return result;
        }

        public static double Primer_3(double x, double y)
        {
            double result;
            result = ((Math.Sin(x) + Math.Cos(y)) / (Math.Cos(x) - Math.Sin(y))) * Math.Tan(x * y);
            return result;
        }

        public static double Primer_4(double x, double y)
        {
            double result;
            result = ((x + y) / (y + 1)) - ((x * y - 12) / (34 + x));
            return result;
        }

        public static double Primer_5(double x, double y)
        {
            double result;
            result = (3 + Math.Exp(y - 1)) / (1 + Math.Pow(x, 2) * Math.Abs(y - Math.Tan(y)));
            return result;
        }

        public static double Primer_6(double x)
        {
            double result;
            result = x - (Math.Pow(x, 3) / 3) + (Math.Pow(x, 5) / 5);
            return result;
        }

        public static double Primer_7(double x, double y)
        {
            double result;
            result = Math.Log(Math.Abs((y - Math.Sqrt(Math.Abs(x))) * (x - y / (x + Math.Pow(x, 2) / 4))));
            return result;
        }

        public static double Primer_8(double x, double y)
        {
            double result;
            result = Math.Pow((1 - Math.Tan(x)), 1 / Math.Tan(x)) + Math.Cos(x - y);
            return result;
        }

        public static double Primer_9(double x)
        {
            double result;
            result = Math.Log(Math.Abs(Math.Cos(x))) / Math.Log(1 + Math.Pow(x, 2));
            return result;
        }

        public static double Primer_10(double x, double y)
        {
            double result;
            result = Math.Pow(((x + 1) / (x - 1)), x) + 18 * x * Math.Pow(y, 2);
            return result;
        }

        public static double Primer_11(double x, double y)
        {
            double result;
            result = Math.Pow((1 + (1 / Math.Pow(x, 2))), x) + 12 * Math.Pow(x, 2) * y;
            return result;
        }

        public static double Primer_12(double x)
        {
            double result;
            result = (x * x - 7 * x - 10) / (x * x - 8 * x + 12);
            return result;
        }

        public static double Primer_13(double x, double y)
        {
            double result;
            result = (Math.Cos(x) / (Math.PI - 2 * x)) + 16 * x * Math.Cos(x * y) - 2;
            return result;
        }

        public static double Primer_14(double x, double y)
        {
            double result;
            result = Math.Pow(2,-x)-Math.Cos(x)+Math.Sin(2*x*y);
            return result;
        }

        public static double Primer_15(double x)
        {
            double result;
            result = 2 * (1 / Math.Tan(3 * x)) - (1 / (12 * x * x + 7 * x - 5));
            return result;
        }

        public static double Primer_16(double x)
        {
            double result;
            result = Math.Abs(Math.Pow(x, 2) - Math.Pow(x, 3)) - (7 * x) / (Math.Pow(x, 3) - 15 * x);
            return result;
        }

        public static double Primer_17(double x, double y)
        {
            double result;
            result = x * Math.Log(x) + (y / (Math.Cos(x) - (x / 3)));
            return result;
        }

        public static double Primer_18(double x)
        {
            double result;
            result = Math.Sin(Math.Sqrt(x + 1)) - Math.Sin(Math.Sqrt(x - 1));
            return result;
        }

        public static double Primer_19(double x, double y)
        {
            double result;
            result = Math.Exp(x) - (y * y + 12 * x * y - 3 * x * x) / (18 * y - 1);
            return result;
        }

        public static double Primer_20(double x, double y)
        {
            double result;
            result = (1 + Math.Sin(Math.Sqrt(x + 1))) / (Math.Cos(12 * y - 4));
            return result;
        }

        public static double Primer_21(double x)
        {
            double result;
            result = 2 * (1 / Math.Tan(3 * x)) - (Math.Log(Math.Cos(x))) / (Math.Log(1 + x * x));
            return result;
        }

        public static double Primer_22(double x)
        {
            double result;
            result = Math.Exp(x) - x - 2 + Math.Pow((1 + x), x);
            return result;
        }

        public static double Primer_23(double x, double y)
        {
            double result;
            result = Math.Pow(3, x) - 4 * x + (y - Math.Sqrt(Math.Abs(x)));
            return result;
        }

        public static double Primer_24(double x)
        {
            double result;
            result = x - 10 * Math.Sin(x) + Math.Abs(Math.Pow(x, 4) - Math.Pow(x, 5));
            return result;
        }

        public static double Primer_25(double x, double y)
        {
            double result;
            result = x - Math.Pow(10, Math.Sin(x)) + Math.Cos(x - y);
            return result;
        }

        public static double Primer_26(double x, double y)
        {
            double result;
            result = (1 + Math.Pow(Math.Sin(x + y), 2)) / (2 + Math.Abs(x - (2 * x) / (1 + x * x * y * y))) + x;
            return result;
        }

        public static double Primer_27(double x, double z)
        {
            double result;
            result = Math.Pow(Math.Cos(Math.Sin(1 / z)), 2);
            return result;
        }

        public static double Primer_28(double a, double b, double c, double d, double f, double x, double y, double z)
        {
            double result;
            result = (Math.Pow(Math.Cos(x), 2) / Math.Sin(x)) - x * y * z + (a * x * x + b * x + c) / (d * Math.Pow(x, 3) - f);
            return result;
        }
    }
}
