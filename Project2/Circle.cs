using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Circle
    {
        
        private double radius;
        public double Radius { get => radius; set => radius = value; }
        const double PI = 3.14;

        public double getSquare()
        {
            return PI* Radius * Radius;
        }

        public double getCircumference()
        {
            return 2 * PI * Radius;
        }

        public void printCircle()
        {
            Console.Write($"Circle: radius = {Radius}, square = {String.Format("{0:0.00}", getSquare())},  perimeter = {String.Format("{0:0.00}", getCircumference())}");
        }

    }
}

       