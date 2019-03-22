using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Function
    {
        public static string[,] Generate(string[,] Field)
        {
            int i = 0, j = 0, k = 1;
            while (i < Field.GetLength(0))
            {
                j = 0;
                while (j < Field.GetLength(1))
                {
                    if (i == 0 && j == 0)
                    {
                        Field[i, j] = ("").ToString();
                    }
                    else if (i == 0 && j != 0)
                    {
                        Field[i, j] = (j).ToString();
                    }
                    else if (i == k && j == 0)
                    {
                        Field[i, j] = (k).ToString();
                        k++;
                    }
                    else
                        Field[i, j] = ((i + j) % 2 == 0 ? "White" : "Black");
                    j++;
                }
                i++;
            }
            return Field;
        }
        public static void PrintArray(string[,] field)
        {
            int i = 0, j = 0;
            while (i < field.GetLength(0))
            {
                j = 0;
                while (j < field.GetLength(1))
                {
                    Console.Write(field[i, j] + "\t");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
        }
        public static int SumColor(string[,] Field, string color)
        {
            int count = new int();
            int i = 0, j = 0;
            while (i < Field.GetLength(0))
            {
                j = 0;
                while (j < Field.GetLength(1))
                {
                    if (Field[i, j] == color)
                    {
                        count++;
                    }
                    j++;
                }
                i++;
            }
            return count;
        }
        public static string ColorCell(string[,] Field, int k, int x)
        {
            return Field[k, x];
        }

        public static string Pawn(int[] FigureUser, int[] FigureAdmin)
        {
            return ((FigureUser[0] == FigureAdmin[0] - 1 && FigureUser[1] == FigureAdmin[1]) || (FigureUser[0] == FigureAdmin[0] - 1 && FigureUser[1] == FigureAdmin[1] + 1) ||
                 (FigureUser[0] == FigureAdmin[0] + 1 && FigureUser[1] == FigureAdmin[1] - 1) || (FigureUser[0] == FigureAdmin[0] + 1 && FigureUser[1] == FigureAdmin[1] + 1)) ?
                 "Атакует" : "Не атакует";
        }
        public static string Elephant(int[] a, int[] b)
        {
            if (b[0] < a[0] && b[1] < a[1])
            {
                while (b[1] != 8 && b[0] != 8)
                {
                    b[0]++;
                    b[1]++;
                    if (b[0] == a[0] && b[1] == a[1])
                        return "Атакует";
                }
            }
            else if (b[0] < a[0] && b[1] > a[1])
            {
                while (b[0] != 8 && b[1] != 1)
                {
                    b[0]++;
                    b[1]--;
                    if (b[0] == a[0] && b[1] == a[1])
                        return "Атакует";
                }

            }
            if (b[0] > a[0] && b[1] < a[1])
            {
                while (b[0] != 1 && b[1] != 8)
                {
                    b[0]--;
                    b[1]++;
                    if (b[0] == a[0] && b[1] == a[1])
                        return "Атакует";
                }

            }
            if (b[0] > a[0] && b[1] > a[1])
            {
                while (b[0] != 1 && b[1] != 1)
                {
                    b[0]--;
                    b[1]--;
                    if (b[0] == a[0] && b[1] == a[1])
                    {
                        return "Атакует";
                    }
                }
            }
            return "Не атакует";
        }

        public static string Slon(int[] a, int[] b)
        {
            for (int i = 0; i < 8; i++)
            {
                if (a[0] + i == a[1] && b[0] + i == b[1]) return "Под ударом";
                if (a[0] - i == a[1] && b[0] - i == b[1]) return "Под ударом";
                if (a[0] + i == a[1] && b[0] - i == b[1]) return "Под ударом";
                if (a[0] - i == a[1] && b[0] + i == b[1]) return "Под ударом";
            }
            return "Безопасно";
        }

        public static string Ladia(int[] a, int[] b)
        {
            for (int i = 0; i < 8; i++)
            {
                if ((a[0] + i == a[1] && b[0] == b[1]) || (a[0] - i == a[1] && b[0] == b[1])) return "Под ударом";
                if ((b[0] + i == b[1] && a[0] == a[1]) || (b[0] - i == b[1] && a[0] == a[1])) return "Под ударом";
            }
            return "Безопасно";
        }
        public static string Ferz(int[] a, int[] b)
        {
            return ((Ladia(a, b) == "Под ударом") || (Slon(a, b) == "Под ударом")) ? "Ferz атакует" : "Ferz не атакует";
        }
        public static string Hourse(int[] a, int[] b)
        {
            if ((a[0] + 2 == b[1] && b[0] + 1 == b[1]) || (a[0] + 2 == a[1] && b[0] - 1 == b[1]) || (a[0] - 2 == a[1] && b[0] + 1 == b[1]) || (a[0] - 2 == a[1] && b[0] - 1 == b[1]) || (a[0] + 1 == a[1] && b[0] + 2 == b[1]) ||
                (a[0] + 1 == a[1] && b[0] - 2 == b[1]) || (a[0] - 1 == a[1] && b[0] + 2 == b[1]) || (a[0] - 1 == a[1] && b[0] - 2 == b[1])) return "Под ударом";
            return "Не атакует";
        }






        public static void Task2()
        {
            Console.WriteLine("Задание 3\n1) сколько дней прошло с начала года; \n2) сколько дней осталось до конца года;\n3) дату предыдущего дня; \n4) дату следующего дня.\n");
            var time = DateTime.Now;
            Console.WriteLine(time.ToShortDateString() + " - Текущая дата");
            Console.WriteLine(Convert.ToInt32(time.Subtract(DateTime.Parse("01.01." + time.Year)).TotalDays) + " дней с начала года");
            Console.WriteLine(Convert.ToInt32(DateTime.Parse("01.01." + time.AddYears(1).Year).Subtract(time).TotalDays) + " До конца года");
            Console.WriteLine(time.AddDays(-1).ToShortDateString() + " - Дата предыдущего дня");
            Console.WriteLine(time.AddDays(1).ToShortDateString() + " - Дата следующего дня");
        }
        public static void Task3()
        {
            int a, b, c, d, v;
            Console.WriteLine("Все трехзначные числа армстронга");
            for (int i = 100; i < 1000; i++)
            {
                a = i / 1000;
                b = i / 100 % 10;
                c = i / 10 % 10;
                d = i % 10;
                if (i < 1000) v = (b * b * b) + (c * c * c) + (d * d * d);
                else v = (a * a * a * a) + (b * b * b * b) + (c * c * c * c) + (d * d * d * d);
                if (v == i) Console.WriteLine(v);
            }
        }
        public static void Task4()
        {
            Console.WriteLine("Введите стороны прямоугольника:");
            int a = getIntFromUser("a"), b = getIntFromUser("b"), a1 = a, b1 = b, counter = 0;
            while (Cut(ref a, ref b)) counter++;
            Console.WriteLine($"Прямоугольник со сторонами {a1} и {b1} можно поделить на {counter} вложенных квадратов максимальной площади\nПрямоугольник со сторонами {a1} и {b1} можно поделить на " + (a1 * b1) + " вложенных квадратов минимальной площади");
        }
        /// <summary> 
        /// Нахождение максимального количества квадратов наибольшей площади, которые можно пИхнуть в прямоугольник 
        /// </summary> 
        /// <param name="a">длина прямоугольника</param> 
        /// <param name="b">ширина прямоугольника</param> 
        /// <returns></returns> 
        public static bool Cut(ref int a, ref int b)
        {

            if (a != 0 && b != 0)
            {
                if (a < b) b -= a; else a -= b;
                return true;
            }
            return false;
        }
        #region Для 2 задания 
        /// <summary> 
        /// Все методы для второго задания работают с координатами в виде 2-х обычных интов, без использования классов и прочей хуеты. Для получения этих координат 
        /// Юзается эта функция переменная = getIntFromUser('Имя этой же переменной') 
        /// </summary> 
        /// <returns></returns> 
        public static int getIntFromUser(string name)
        {
            while (true)
            {
                Console.WriteLine($"Введите значение [{name}]");
                if (int.TryParse(Console.ReadLine(), out int n))
                {
                    if (n > 0)
                        return n;
                    Console.WriteLine("Wrong value. You must input number");
                }
                else
                {
                    Console.WriteLine("Wrong value. You must inputnumber");
                }
            }
        }
        #endregion
    }
}
