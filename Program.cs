namespace Logical_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the Program You Want To Run");
            Console.WriteLine("\n1.Square of Number \n2.text_convert \n3.String_conversion \n4.average \n5.perimeter_area perimeter_Area ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Squareroot squareroot = new Squareroot();
                   
                    break;
                    case 2:
                    text_convert text = new text_convert();
                    break;
                    case 3:
                    String_conversion string_Conversion = new String_conversion();
                    break;
                    case 4:
                    average average = new average();
                    break;
                    case 5:
                    perimeter_area perimeter_Area = new perimeter_area();
                    break;
                    case 6:
                  
                    break;
            }
        }
    }

   
}