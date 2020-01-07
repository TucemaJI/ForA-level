using System;

namespace Project2
{
    class Program
    {
        private static int Parsing(int count)
        {
            int result;
            while (true)
            {
                try
                {
                    Console.Write("Enter №" + count + " = ");
                    result = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter a number");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Enter a less number");
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            double result;
            while (true)
            {
                int n1 = Parsing(1);
                int n2 = Parsing(2);
                result = (double)n1 / (double)n2;
                Console.WriteLine("Result = " + result);
            }
        }
    }
}
