namespace Homework008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter year: ");
            string year=Console.ReadLine();
            if(int.TryParse(year, out int number))
            {
                Console.WriteLine(" ASR: " + findasr(number));
            }
            else
            {
                Console.WriteLine(" Faqat butun son kirita olasiz !!!");
            }
            Main(args);

        }
        public static int findasr(int number)
        {
           return number / 100;
        }
    }
}