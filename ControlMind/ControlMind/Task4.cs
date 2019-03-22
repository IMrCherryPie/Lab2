using System;

namespace ControlMind
{
    class Task4
    {
        public static void MonthOfYear()
        {
            Console.Write("Введите день"); int day = int.Parse(Console.ReadLine());
            Console.Write("Введите месяц"); int month = int.Parse(Console.ReadLine());
            Console.Write("Введите год"); int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количестов месяцев которые прошли с момента ...");
            Console.Write("Введите месяц"); int monthMod = int.Parse(Console.ReadLine());
            DateTime time = new DateTime(year, month, day);
            Console.WriteLine("Введена DATE: {0:D}", time);
            Console.WriteLine("New DATE: {0:D}", time.AddMonths(monthMod));
        }
    }
}
