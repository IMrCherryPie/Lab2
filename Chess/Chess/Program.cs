using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 9;
            int k1, x1, k2, x2, caseSwit;
            string color;
            string[,] Field = new string[size, size];
            bool identical;
            Field = Function.Generate(Field);
            Function.PrintArray(Field);
            while (true)
            {
                Console.WriteLine("1 - для первого задания");
                Console.WriteLine("2 - для второго задания");
                Console.WriteLine("3 - для третьего задания");
                Console.WriteLine("4 - для четвёртого задания");
                Console.WriteLine("5 - для пятого задания");

                caseSwit = Convert.ToInt32(Console.ReadLine());
                switch (caseSwit)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите искомый цвет Black or White");
                            color = Console.ReadLine();
                            Console.WriteLine(Function.SumColor(Field, color));
                            Console.WriteLine("Введите координаты сравниваемых ячеек дабы узнать расист вы или неет.");
                            k1 = Convert.ToInt32(Console.ReadLine());
                            x1 = Convert.ToInt32(Console.ReadLine());
                            Function.ColorCell(Field, k1, x1);
                            k2 = Convert.ToInt32(Console.ReadLine());
                            x2 = Convert.ToInt32(Console.ReadLine());
                            identical = ((Field[k1, x1] == Field[k2, x2]) ? true : false);
                            Console.WriteLine("Вы расист? " + identical);
                            Console.WriteLine("По по координатам " + k1 + " " + x1 + " находится ячейка " + Function.ColorCell(Field, k2, x2) + "  цвета ");
                            Console.WriteLine("По по координатам " + k2 + " " + x2 + " находится ячейка " + Function.ColorCell(Field, k2, x2) + "  цвета ");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Введите положение своей фигуры.");
                            int[] FigureUser = new int[2];
                            int[] FigureAdmin = new int[2];
                            FigureUser[0] = Convert.ToInt32(Console.ReadLine());
                            FigureUser[1] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите положение фигуры противника.");
                            FigureAdmin[0] = Convert.ToInt32(Console.ReadLine());
                            FigureAdmin[1] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Пешка "+Function.Pawn(FigureUser, FigureAdmin));
                            Function.Elephant(FigureUser, FigureAdmin);
                            Console.WriteLine(Function.Slon(FigureUser, FigureAdmin)+ " Слона");
                            Console.WriteLine("Ладья - "+Function.Ladia(FigureUser, FigureAdmin));
                            Console.WriteLine("Ферзь - "+Function.Ferz(FigureUser, FigureAdmin));
                            Console.WriteLine("Конь - "+Function.Hourse(FigureUser, FigureAdmin));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Задание 2 ");
                            Function.Task2();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Задание 3 ");
                            Function.Task3();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Задание 4 ");
                            Function.Task4();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine();
                            break;
                        }
                }
            }
            Console.ReadKey();
        }
    }
}
