using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadacha_19_300
{
    // Семакин задача 19 300 с.
    //Написать программу, которая выводит на экран первые четыре степени числа PI.
    class Zadacha_19_300
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("{0} степень числа PI: {1:0.#######}",i, Math.Pow(Math.PI,i));
            }
            Console.ReadKey();
        }
    }
}
