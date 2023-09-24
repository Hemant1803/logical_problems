namespace Logical_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the Program You Want To Run");
            Console.WriteLine("\n1.Square of Number");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Squareroot squareroot = new Squareroot();
                   
                    break;
            }
        }
    }
}