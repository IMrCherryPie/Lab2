using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using laba2;

namespace lab6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex t1 = new Complex(1, 1);
            Complex t2 = new Complex(2, 3);
            Complex t3 = new Complex(t1, t2);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
        }
    }
}
