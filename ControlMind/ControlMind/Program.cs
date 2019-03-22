using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlMind
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выбор задания от 1 до 4");
                int number;
                number = int.Parse(Console.ReadLine());
                switch(number){
                    case 1:
                        Task1.VolumeCube(); 
                        break;
                    case 2:
                        Task2.EvenlySum();
                        break;
                    case 3:
                        Task3.CheckInside();
                        break;
                    case 4:
                        Task4.MonthOfYear();
                        break;

                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }
        }
    }
}
