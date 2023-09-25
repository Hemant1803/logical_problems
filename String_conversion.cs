using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class String_conversion
    {
        public String_conversion() {
            {
                Console.WriteLine("Enter a number:");
                string num = Console.ReadLine();

                if (int.TryParse(num, out int number))
                {
                    
                    string result = (number * 10).ToString();

                    Console.WriteLine($"10 times of the number: {result}");
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }

                Console.ReadLine();
            }
        }
    }
}
