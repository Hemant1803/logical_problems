using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class text_convert
    {
        public text_convert()
        {
            Console.WriteLine("Enter your name or a word which you want to convert in upper case or lower case");
            string text = Console.ReadLine();

            Console.WriteLine("Name or Word In Uppercase: " + text.ToUpper());
            Console.WriteLine("Name or Word In lowercase: " + text.ToLower());

            Console.ReadLine();
        }

    }
}
