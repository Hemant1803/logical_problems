using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Logical_Programs
{
    internal class Squareroot
    {
         public Squareroot() 
        {
            Console.WriteLine("Enter a Number You Want To Squareroot");
            double num = Convert.ToDouble(Console.ReadLine());
            double squareroot = Math.Sqrt(num);
            Console.WriteLine($"The Square Root of the {num} is :-" + squareroot);
        }
    }
}
