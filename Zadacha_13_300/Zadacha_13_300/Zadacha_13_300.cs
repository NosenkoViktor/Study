using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_13_300
{
    // Семакин страница 300 задача № 13: 
    // Найти площадь равнобедренной трапеции с основаниями а и b и углом Alfa при большем основании а.

    class Zadacha_13_300
    {
        static void Main(string[] args)
        {
            // Создаем новый обьект класса Trap
            Trap tr = new Trap(10, 7.5, 45);

            // Выводим информацию о бьекте в консоль
            Console.WriteLine(tr.ToString());

            // Используем метод GetArea для получения площади трапеции выводим информацию в консоль
            Console.WriteLine("Площадь трапеции равна: {0:0.####} кв. едениц", tr.GetArea());
            Console.WriteLine();

            // Используем статический метод GetArea для получения площади трапеции по переменным не создавая обьект выводим информацию в консоль
            Console.WriteLine("Площадь трапеции равна: {0:0.####} кв. едениц", Trap.GetArea(12.5, 8, 90));

            Console.ReadLine();
        }
    }

    class Trap
    {
        // Переменные класса
        double a, b, alfa;

        /// <summary>
        /// Коструктор класса
        /// </summary>
        /// <param name="a">Основа трапеции</param>
        /// <param name="b">Сторона</param>
        /// <param name="alfa">Угол у основания</param>
        public Trap(double a, double b, double alfa)
        {
            this.a = a;
            this.b = b;
            this.alfa = alfa;
        }

        /// <summary>
        /// Статический метод расчета площади трапеции 
        /// </summary>
        /// <param name="a">Основа трапеции</param>
        /// <param name="b">Сторона</param>
        /// <param name="alfa">Угол у основания</param>
        /// <returns>Значение площади в квадртатных еденицах</returns>
        public static double GetArea(double a, double b, double alfa)
        {
            double area;
            area = b * Math.Sin(alfa) * (a + b * Math.Cos(alfa));
            return area;
        }

        /// <summary>
        /// Метод расчета площади трапеции в качестве переменных для расчета берутся переменные обьекта
        /// </summary>
        /// <returns>Значение площади в квадртатных еденицах</returns>
        public double GetArea()
        {
            double area;
            area = b * Math.Sin(alfa) * (a + b * Math.Cos(alfa));
            return area;
        }

        /// <summary>
        /// Переписываем метод ToString для вывода информации о обьекте класса
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Основание трапеции а: {0}, сторона b: {1}, угол у основания alfa: {2}", a, b, alfa);
        }
    }
}
