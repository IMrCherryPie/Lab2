using System;

namespace ControlMind
{
    class Task1
    {
        public static void VolumeCube() {
            Console.WriteLine("Введите объём куба чтобы найти его ребро");
            Console.Write("V = ");
            float v = float.Parse(Console.ReadLine());
            double a = Math.Pow(v,1.0/2.0);
            Console.WriteLine("a =" + a);
        }
    }
}
