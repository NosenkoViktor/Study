using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadacha_32_301
{
    /* Семакин задача 32 301с.
     * Дано натуральное число Т, которое представляет длительность
     * прошедшего времени в секундах. Вывести данное значение
     * длительности в часах, минутах и секундах в следующей форме:ННч ММ мин SSc.
     * 
     * Как я понял из условия нужно вывести все время в часах все время в минутах и секундах 
     * которое прошло с момента времени 0 до момента Т в сек.
     * 
     * Не уверен что она сделана правильно. Буду рад критике.
     */
    class Zadacha_32_301
    {
        static void Main(string[] args)
        {
            ulong t = 5465446465;
            
            // Так как задачу нужно решить используя классы используем класс TimeSpan который дает временной промежуток
            TimeSpan ts = TimeSpan.FromSeconds(t);

            // Количество часов выводим через деления t на 3600 чтобы получить целое количество часов, 
            // так как при использовании свойства TotalHours получаем целую и дробную часть что не удовлетворяет условие,
            // а свойство Hours дает временной интервал в "текущих" сутках
            // все остальное находим с помощью свойств Minutes и Seconds обьекта класса
            Console.WriteLine("{0}:{1:0}:{2:0}", t / 3600, ts.Minutes, ts.Seconds);

            // Не використовуючи класів .NET
            Console.WriteLine(IntToDate(t));

            Console.ReadKey(); 
        }

        public static string IntToDate(ulong timeInSecond)
        {
            return string.Format("{0}:{1}:{2}", timeInSecond / 3600, timeInSecond / 60 % 60, timeInSecond % 60);
        }
    }
}
