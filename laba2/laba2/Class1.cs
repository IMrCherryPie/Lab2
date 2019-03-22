using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public class Complex
    {
        double re, im;
        public Complex(double r, double i)
        {
            re = r;
            im = i;
        }
        public static Complex Sum (Complex C1, Complex C2)
        {
           return new Complex (C1.re + C2.re, C1.im + C2.im);
        }
        public void ToString()
        {
           Console.WriteLine("re = " + re +" im = "+im);
        }
    }
}
