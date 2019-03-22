using System;

namespace ControlMind
{
    class Task3
    {
        public static void CheckInside()
        {
            Console.Write("Введите X"); int x = int.Parse(Console.ReadLine());
            Console.Write("Введите Y"); int y = int.Parse(Console.ReadLine());
            if (Math.Abs(x) == y && y < 20) Console.WriteLine("На шранице");
            else if (y > 20 || Math.Abs(x) > y) Console.WriteLine("За границей");
            else Console.WriteLine("Внутри");

        }
    }
}
