namespace Homework008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter number: ");
            string son=Console.ReadLine();
            if(int.TryParse(son, out int value))
            {
                Console.WriteLine(" Xona: "+Xonasinianiq(son));
            }
            else
            {
                Console.WriteLine(" Not an integer number !!!");
            }
            Main(args);
        }
        public static int Xonasinianiq(string son,int nuber)
        { 
                return son.Length;     
        }
    }
}