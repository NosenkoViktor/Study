using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_7_300
{
    class Zadacha_7_300
    {
        /* Семакин страница 300 задача № 7: 
         * Даны два действительных числа х и у. Вычислить их сумму, разность, произведение и частное.
         * 
         * Не совсем понял какие именно класы тут нужно использовать впринципе все делается с помошью бинарных операторов и использования простых типов.
         * В классе Math нету явных методов для суммы разности, произведения и частного.
         * Как вариант могу создать обьект собственного класса с двумя переменными х и у 
         * и метод для данного обьекта класса который будет возвращать значения суммы, разности, произведения и частного
         * и наверное метод который будет возвращать все и сразу.
         * 
         * А ну и книга Семакина как я понял по паскалю по этому типа Real у нас нету 
         * самы близкий всеохватывающий тип к действительным как по мне double буду юзать эго.
         *
         */

        static void Main(string[] args)
        {
            // Создаем новый обьект класса Elements используя конструктор
            Elements e1 = new Elements(1.5, 2);
            Elements e2 = new Elements(2, 2.25);

            // Выводим в консоль информацию о переменных
            Console.WriteLine(e1.ToString());
            Console.WriteLine();

            // Вызов методов суммы, разности, произведения и частного
            Console.WriteLine("Сумма: " + e1.SummXY());
            Console.WriteLine("Разница: " + e1.SubtractXY());
            Console.WriteLine("Произведение: " + e1.MultiplicationXY());
            Console.WriteLine("Частное: " + e1.DivisionXY());
            Console.WriteLine();

            // Обьявления переменных для записи суммы, разности, произведения и частного после работы метода AllOperationXY
            double summ, substr, mult, divis;

            // Вызов метода AllOperationXY
            Console.WriteLine(e2.AllOperationXY(out summ, out substr, out mult, out divis));

            Console.WriteLine();
            Console.WriteLine("Перегрузка операторов");
            Elements d = e1+e2;
            Console.WriteLine(d.ToString());
            d = d - 3;
            Console.WriteLine(d.ToString());
            d++;
            Console.WriteLine(d.ToString());
            d--;
            Console.WriteLine(d.ToString());
            d = d * 2;
            Console.WriteLine(d.ToString());
            d = d/2;
            Console.WriteLine(d.ToString());
            d += 5;
            Console.WriteLine(d.ToString());
            d = d * e1;
            Console.WriteLine(d.ToString());
            Console.WriteLine(d == e1);
            Console.WriteLine(e1 != e2);
            

            // Задержка консоли
            Console.ReadKey();
        }
    }

    class Elements
    {
        // Обьявили переменные (по умолчанию private)
        double x, y;

        // Конструктор класса
        public Elements(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // Переписываем метод ToString для вывода информации о обьекте класса в нашем случае переменных x, y
        public override string ToString()
        {
            return string.Format("Переменная Х: {0}, Переменная Y: {1}", x, y);
        }

        /// <summary>
        /// Сумирование переменных обьекта
        /// </summary>
        /// <returns>Результат сумирования</returns>
        public double SummXY()
        {
            double result;
            result = x + y;
            return result;
        }

        /// <summary>
        /// Разница переменных обьекта
        /// </summary>
        /// <returns>Результат вычитания</returns>
        public double SubtractXY()
        {
            double result;
            result = x - y;
            return result;
        }

        /// <summary>
        /// Произведение переменных обьекта
        /// </summary>
        /// <returns>Результат произведения</returns>
        public double MultiplicationXY()
        {
            double result;
            result = x * y;
            return result;
        }

        /// <summary>
        /// Частное переменных обьекта 
        /// </summary>
        /// <returns>Результат деления</returns>
        public double DivisionXY()
        {
            double result;
            result = x / y;
            return result;
        }

        /// <summary>
        /// Метод выводящий все перечисленные выше операции над обьектом и строку с информацией о проведенных действиях
        /// так как возле типа переменных sum, substr, mult, divis указан модификатор out значения будут возвращены из метода
        /// </summary>
        /// <param name="sum">Переменная сумы</param>
        /// <param name="substr">Переменная разницы</param>
        /// <param name="mult">Переменная произведения</param>
        /// <param name="divis">Переменная частного</param>
        /// <returns>Строка с результатом работы метода</returns>
        public string AllOperationXY(out double sum,out double substr,out double mult,out double divis)
        {
            sum = x + y;
            substr = x - y;
            mult = x * y;
            divis = x / y;
            return string.Format("Для обьекта с переменными Х: {0}, Y: {1} \n сумма: {2} \n разница: {3} \n произведение: {4} \n частное: {5}",
                x,
                y,
                sum,
                substr,
                mult,
                divis);
        }

        // Перегрузка операторів 

        // Перегрузка сумми для 2 х елементів і варіант з додаванням коефіцієнта
        public static Elements operator +(Elements first, Elements second)
        {
            return new Elements(first.x + second.x, first.y + second.y);
        }
        public static Elements operator +(Elements a, double cof)
        {
            return new Elements(a.x + cof, a.y + cof);
        }

        // Те ж саме для різниці
        public static Elements operator -(Elements first, Elements second)
        {
            return new Elements(first.x - second.x, first.y - second.y);
        }
        public static Elements operator -(Elements a, double cof)
        {
            return new Elements(a.x - cof, a.y - cof);
        }

        // Множення 
        public static Elements operator *(Elements first, Elements second)
        {
            return new Elements(first.x * second.x, first.y * second.y);
        }
        public static Elements operator *(Elements a, double cof)
        {
            return new Elements(a.x * cof, a.y * cof);
        }

        // Ділення
        public static Elements operator /(Elements first, Elements second)
        {
            if (second.x !=0 && second.y != 0) return new Elements(first.x / second.x, first.y / second.y);
            else 
            {
                Console.WriteLine("Ділення на 0 недопустиме");
                return new Elements(0, 0);
            }
        }

        public static Elements operator /(Elements a, double cof)
        {
            if (cof != 0) return new Elements(a.x / cof, a.y / cof);
            else
            {
                Console.WriteLine("Ділення на 0 недопустиме");
                return new Elements(0, 0);
            }
        }

        // Інкримент
        public static Elements operator ++(Elements a)
        {
            return new Elements(a.x+1, a.y+1);
        }

        // Декримент
        public static Elements operator --(Elements a)
        {
            return new Elements(a.x-1, a.y-1);
        }

        // Порівняння 
        public static bool operator ==(Elements first, Elements second)
        {
            if (first.x == second.x && first.y == second.y) return true;
            else return false;
        }

        public static bool operator !=(Elements first, Elements second)
        {
            if (first.x != second.x || first.y != second.y) return true;
            else return false;
        }
    }
}
