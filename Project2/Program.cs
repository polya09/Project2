using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Circle circle = new Circle();
            Console.WriteLine("Input Radius: ");
            double Radius;
            circle.Radius = double.Parse(Console.ReadLine());
           
            Console.WriteLine($"Square = {circle.getSquare()}");
            Console.WriteLine($"Circumference = {circle.getCircumference()}");
            Console.ReadKey();

        }
    }
}
   

