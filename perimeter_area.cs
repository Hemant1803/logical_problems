using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class perimeter_area
    {
      public  perimeter_area() {
            Console.WriteLine("Enter the diameter of the circle:");
            double diameter = Convert.ToDouble(Console.ReadLine());           
            double radius = diameter / 2;           
            double perimeter = 2 * Math.PI * radius;           
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Perimeter of the circle: {perimeter}");
            Console.WriteLine($"Area of the circle: {area}");
            Console.ReadLine();
        }
    }
}
