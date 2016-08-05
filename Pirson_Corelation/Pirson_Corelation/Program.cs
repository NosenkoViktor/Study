using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirson_Corelation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здраствуйте");
            Console.WriteLine();

        lable0:
            Console.Write("Введите количество елементов массива: ");
            int n = 0;
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введеная строка не является целым числом или меньше 0");
                Console.WriteLine("Количество елементов задается целочисленным числом больше нуля!!!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                goto lable0;
            }
            if (n < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введеная строка не является целым числом или меньше 0");
                Console.WriteLine("Количество елементов задается целочисленным числом больше нуля!!!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
                goto lable0;
            }
            Console.WriteLine();

            Methods m = new Methods();
            m.Entry(n);
            Console.WriteLine();
            m.Mediana();
            m.Moda();
            m.StepToStep();
            m.StandardDeviation(n);
            m.Covariation();
            m.MaxSumarry();
            m.Corelation(n);

        label1:
            Console.WriteLine("Сохранить в виде txt файла полученую информацию (ДА/НЕТ)");
            string answer = Console.ReadLine().ToLower();

            if (answer.Equals("да"))
            {
                Console.WriteLine("Введите имя для сохранения файла");
                string name = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(m.SaveToFile(name));
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine("Для выхода из програмы нажмите любую клавишу.");
            }
            else if (answer.Equals("нет")) Console.WriteLine("Для выхода из програмы нажмите любую клавишу.");
            else goto label1;

            Console.ReadKey();
        }
    }
}
