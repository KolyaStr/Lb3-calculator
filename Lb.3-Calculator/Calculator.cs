using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb._3_Calculator
{
    class Calculator
    {
        private double sum = 0;
        private double minus = 0;
        private double mult = 0;
        public double x { get; set; }
        public double y { get; set; }

        public void Plus(double x, double y)
        {
            sum = x + y;
            Console.WriteLine($"{x} + {y} = {Math.Round(sum, 3)}");
        }
        public void Minus(double x, double y)
        {
            minus = x - y;
            Console.WriteLine($"{x} - {y} = {Math.Round(minus,3)}");
        }
        public void Mult(double x, double y)
        {
            mult = x * y;
            Console.WriteLine($"{x} * {y} = {Math.Round(mult, 3)}");
        }
    }
}
