namespace Homework008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter number: ");
            string son=Console.ReadLine();
            if(double.TryParse(son, out double raqam)) 
            {
                Console.WriteLine(Find(raqam));
            }
            else
            {
                Console.WriteLine(" Faqat son kirita olasiz !!!");
            }
            Main(args);
        }
        public static string Find( double raqam)
        {
            if(raqam > 0)
            {
                return " 0 < entered number " +
                    "+";
            }
            else if(raqam < 0)
            {
                return " 0 > entered number" +
                    "-";
            }
            else
            {
                return " 0 = entered number" +
                    "0";
            }
        }
    }
}