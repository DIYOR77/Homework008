using System.Security.Cryptography.X509Certificates;

namespace Homework008
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write(" X : ");
            string son = Console.ReadLine();
            Console.Write(" Y : ");
            string son2 = Console.ReadLine();

            if ((double.TryParse(son, out double number1)) && (double.TryParse(son2, out double number2)))
            {
                Console.WriteLine();
                Console.WriteLine(" X : " + maxandmin(number1, number2));

                if (number1 < number2)
                {
                    Console.WriteLine(" Y : " + number1);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(" Y : " + number2);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine(" NOT number !!!");
                Console.WriteLine();
            }
            Main(args);
        }
        public static double maxandmin(double number1,double number2) 
        {
            if (number1 > number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }
    }
}