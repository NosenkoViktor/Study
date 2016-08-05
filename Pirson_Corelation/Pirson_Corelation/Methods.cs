using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirson_Corelation
{
    class Methods
    {
        // Переменные
        double meanX, meanY, cov, maxSum;

        // Массивы для которых будут вестись расчеты
        double[] firstArray;
        double[] secondArray;

        // Массивы в которых хранятся средние значения для каждого елемента массива
        double[] meanFirstArray;
        double[] meanSecondArray;

        // Список создан для дальнейшей записи в файл результатов расчетов
        List<string> list = new List<string>();

        /// <summary>
        /// Процедура вносит елементы в первый и второй массив
        /// Выводит их в консоль и добавляет соответствующие строки в list
        /// </summary>
        /// <param name="n">Количество елементов массива</param>
        public void Entry(int n)
        {
            firstArray = new double[n];
            secondArray = new double[n];
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Елементы массивов следует вводить в формате #,####");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Введите елементы первого масива (X):");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < n;)
            {
                double element;
                if (double.TryParse(Console.ReadLine(), out element))
                {
                    firstArray[i] = element;
                    i++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Некоректный ввод елемента.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Введите елементы второго масива (Y):");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < n; )
            {
                double element;
                if (double.TryParse(Console.ReadLine(), out element))
                {
                    secondArray[i] = element;
                    i++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Некоректный ввод елемента.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("X:   ");
            Console.ForegroundColor = ConsoleColor.White;
            String first = "X:  ", second = "Y:  ";
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write(firstArray[i]);
                first += firstArray[i] + " | ";
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(" | ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Y:   ");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write(secondArray[i]);
                second += secondArray[i] + " | ";
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(" | ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine();
            list.Add(first);
            list.Add(second);
            list.Add("   ");
        }

        /// <summary>
        /// Процедура находит медиану для двух массивов, выводит в консоль и добавляет соответствующие строки в list
        /// </summary>
        public void Mediana()
        {
            double med1, med2;
            if (firstArray.Length % 2 == 0)
            {
                int mid = firstArray.Length / 2;
                med1 = (firstArray[mid] + firstArray[mid - 1]) / 2;
            }
            else
            {
                int mid = firstArray.Length / 2;
                med1 = firstArray[mid];
            }

            if (secondArray.Length % 2 == 0)
            {
                int mid = secondArray.Length / 2;
                med2 = (secondArray[mid] + secondArray[mid - 1]) / 2;
            }
            else
            {
                int mid = secondArray.Length / 2;
                med2 = secondArray[mid];
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Медиана первого массива Х: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(med1);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Медиана второго массива Y: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(med2);
            list.Add(string.Format("Медиана первого массива Х: {0}", med1));
            list.Add(string.Format("Медиана второго массива Y: {0}", med2));
            list.Add("   ");
            Console.WriteLine();
        }

        /// <summary>
        /// Процедура находит моду для двух массивов, выводит в консоль и добавляет соответствующие строки в list
        /// </summary>
        public void Moda()
        {
            int max = 0;
            double moda = 0.0;

            for (int i = 0; i < firstArray.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < firstArray.Length; j++)
                {
                    if (firstArray[i] == firstArray[j]) count++;
                }
                if (max < count)
                {
                    max = count;
                    moda = firstArray[i];
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Мода первого (X) массива: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine((max == 1) ? "<Елементы в массиве не повторяются>" : moda.ToString());
            list.Add(string.Format("Мода первого (X) массива: {0}", (max == 1) ? "<Елементы в массиве не повторяются>" : moda.ToString()));

            max = 0;
            for (int i = 0; i < secondArray.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < secondArray.Length; j++)
                {
                    if (secondArray[i] == secondArray[j]) count++;
                }
                if (max < count)
                {
                    max = count;
                    moda = secondArray[i];
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Мода второго (Y) массива: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine((max == 1) ? "<Елементы в массиве не повторяются>" : moda.ToString());
            list.Add(string.Format("Мода второго (Y) массива: {0}", (max == 1) ? "<Елементы в массиве не повторяются>" : moda.ToString()));
            list.Add("  ");
            Console.WriteLine();
        }

        /// <summary>
        /// Процедура расчета дельта значений каждго елемента для записи в файл 
        /// В консоль выводится только среднее значение
        /// </summary>
        public void StepToStep()
        {
            meanFirstArray = new double[firstArray.Length];
            meanSecondArray = new double[secondArray.Length];
            double elementSummary = 0;
            for (int i = 0; i < firstArray.Length; i++)
            {
                elementSummary += firstArray[i];
            }
            meanX = elementSummary / firstArray.Length;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Среднее значение для первого (Х) массива: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0:0.0000}", meanX);
            list.Add(string.Format("Среднее значение для первого (Х) массива: {0:0.0000}", meanX));

            elementSummary = 0;
            for (int i = 0; i < secondArray.Length; i++)
            {
                elementSummary += secondArray[i];
            }
            meanY = elementSummary / secondArray.Length;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Среднее значение для второго (Y) массива: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0:0.0000}", meanY);
            list.Add(string.Format("Среднее значение для второго (Y) массива: {0:0.0000}", meanY));
            list.Add("   ");

            list.Add("Расчет разницы среднего значения и елемента для двух массивов Х и Y");
            list.Add("   ");
            for (int i = 0; i < firstArray.Length; i++)
            {
                double x = firstArray[i] - meanX;
                meanFirstArray[i] = x;
                list.Add(string.Format("\u0394x[{0}] = {1:0.0000}", i + 1, x));
            }
            list.Add("   ");

            for (int i = 0; i < secondArray.Length; i++)
            {
                double y = secondArray[i] - meanY;
                meanSecondArray[i] = y;
                list.Add(string.Format("\u0394y[{0}] = {1:0.0000}", i + 1, y));
            }
            list.Add("   ");
            Console.WriteLine();
        }

        /// <summary>
        /// Процедура нахождения: 
        /// Cреднеквадратического отклонения sigma
        /// Дисперсии Dx
        /// </summary>
        public void StandardDeviation(int n)
        {
            double sigmaX, sigmaY, Dx, Dy;
            if (n < 30)
            {
                double d = 0;
                for (int i = 0; i < meanFirstArray.Length; i++)
                {
                    d += meanFirstArray[i] * meanFirstArray[i];
                }
                Dx = d / (n - 1);
                sigmaX = Math.Sqrt(Dx);

                d = 0;
                for (int i = 0; i < meanSecondArray.Length; i++)
                {
                    d += meanSecondArray[i] * meanSecondArray[i];
                }
                Dy = d / (n - 1);
                sigmaY = Math.Sqrt(Dy);
            }
            else
            {
                double d = 0;
                for (int i = 0; i < meanFirstArray.Length; i++)
                {
                    d += meanFirstArray[i] * meanFirstArray[i];
                }
                Dx = d / n;
                sigmaX = Math.Sqrt(Dx);

                d = 0;
                for (int i = 0; i < meanSecondArray.Length; i++)
                {
                    d += meanSecondArray[i] * meanSecondArray[i];
                }
                Dy = d / n;
                sigmaY = Math.Sqrt(Dy);
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Cреднеквадратическое отклонение первого массива (Х) равно: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0:0.0000}", sigmaX);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Дисперсия (X): ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0:0.0000}", Dx);
            list.Add(string.Format("Cреднеквадратическое отклонение первого массива (Х) равно: {0:0.0000}", sigmaX));
            list.Add(string.Format("Дисперсия (X) равна: {0:0.0000}", Dx));
            list.Add("  ");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Cреднеквадратическое отклонение второго массива (Y) равно: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0:0.0000}", sigmaY);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Дисперсия (Y): ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0:0.0000}", Dy);
            list.Add(string.Format("Cреднеквадратическое отклонение второго массива (Y) равно: {0:0.0000}", sigmaY));
            list.Add(string.Format("Дисперсия (Y) равна: {0:0.0000}", Dy));
            Console.WriteLine();
            list.Add("   ");
        }

        /// <summary>
        /// Процедура нахождения КОВАРИАЦИИ или Суммы произведений отклонений
        /// </summary>
        public void Covariation()
        {
            cov = 0;
            list.Add("Сумма произведений отклонений для каждого елемента");
            list.Add("  ");
            for (int i = 0; i < meanFirstArray.Length; i++)
            {
                double c;
                c = meanFirstArray[i] * meanSecondArray[i];
                cov += c;
                list.Add(string.Format("\u0394x[{0}] * \u0394y[{0}] = {1:0.0000}", i + 1, c));
            }
            list.Add("  ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Сумма произведений отклонений S1: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0:0.0000}", cov);
            list.Add(string.Format("Сумма произведений отклонений S1: {0:0.0000}", cov));
            list.Add("  ");
        }

        /// <summary>
        /// Процедура нахождения максимальной суммы
        /// </summary>
        public void MaxSumarry()
        {
            double sumX = 0, sumY = 0, sum;
            list.Add("Квадраты \u0394x");
            list.Add("  ");
            for (int i = 0; i < meanFirstArray.Length; i++)
            {
                double x;
                x = meanFirstArray[i] * meanFirstArray[i];
                sumX += x;
                list.Add(string.Format("\u0394x[{0}] * \u0394x[{0}] = {1:0.0000}", i + 1, x));
            }

            list.Add("  ");
            list.Add("Квадраты \u0394y");
            list.Add("  ");
            for (int i = 0; i < meanSecondArray.Length; i++)
            {
                double y;
                y = meanSecondArray[i] * meanSecondArray[i];
                sumY += y;
                list.Add(string.Format("\u0394y[{0}] * \u0394y[{0}] = {1:0.0000}", i + 1, y));
            }
            list.Add("  ");
            sum = sumX * sumY;
            list.Add(string.Format("Мксимальная сумма в квадрате (S2 * S2): {0:0.0000}", sum));
            list.Add("  ");
            maxSum = Math.Sqrt(sum);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Максимальная сумма S2: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0:0.0000}", maxSum);
            list.Add(string.Format("Максимальная сумма S2: {0:0.0000}", maxSum));
            list.Add("  ");
        }

        /// <summary>
        /// Процедура нахождения:
        /// Коефициента кореляции r 
        /// Средней ошибки кореляции m
        /// Критерия достоверности кореляции t
        /// </summary>
        /// <param name="n">Количество елементов массива</param>
        public void Corelation(int n)
        {
            double r = cov / maxSum, m, t;
            m = Math.Sqrt((1 - r*r) / (n - 2));
            t = r / m;

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Коефициент кореляции R: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0:0.0000}", r);
            list.Add(string.Format("Коефициент кореляции R: {0:0.0000}", r));

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Среднее значения ошибки коефициента кореляции m: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0:0.0000}", m);
            list.Add(string.Format("Среднее значения ошибки коефициента кореляции m: {0:0.0000}", m));

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Критерий достоверности кореляции t: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0:0.0000}", t);
            list.Add(string.Format("Критерий достоверности кореляции t: {0:0.0000}", t));
            Console.WriteLine();
            list.Add("    ");
            list.Add("_______________________________________________________________________________________");
            list.Add("    ");
        }

        /// <summary>
        /// Метод для записи в файл кореляционных данных
        /// </summary>
        /// <param name="path">Путь файла на запись</param>
        /// <returns>Строка о состоянии записи</returns>
        public string SaveToFile(string name)
        {
            string workspase = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string newPath = @workspase + "\\" + name + ".txt";
            Console.WriteLine();
            StreamWriter sw = File.AppendText(newPath);

            foreach (string s in list) sw.WriteLine(s);
            sw.Close();

            return string.Format("Файл успешно записан на рабочем столе: \n" + newPath);
        }
    }
}
