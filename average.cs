using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class average
    {
        public average()
        {
            Random random = new Random();


            int[] num = new int[5];
            int sum = 0;


            Console.Write("Generated Numbers: ");
            for (int i = 0; i < 5; i++)
            {
                num[i] = random.Next(10, 51); 
                Console.Write(num[i] + " ");
                sum += num[i];
            }

           
            double average = (double)sum / 5;

            Console.WriteLine("\nAverage: " + average);

            Console.ReadLine(); 
        
    }
    }
}
