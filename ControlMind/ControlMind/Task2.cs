using System;

namespace ControlMind
{
    class Task2
    {
        public static void EvenlySum() {
            Console.WriteLine("Сумма числе a and b чётна?");
            Console.Write("a= "); float a = float.Parse(Console.ReadLine());
            Console.Write("b= "); float b = float.Parse(Console.ReadLine());
            Console.WriteLine( (((a + b) % 2) == 0) ? true :false);
        }
    }
}
