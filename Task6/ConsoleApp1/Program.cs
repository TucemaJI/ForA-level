using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Processor
    {
        public static void ProcessInput(int numint)
        {
            Console.WriteLine("Fizz");
        }

        public static void ProcessInput(double numdouble)
        {
            Console.WriteLine("Buzz");
        }
        public Processor(string enter)
        {
            int numint;
            double numdouble;
            if (int.TryParse(enter, out numint))
            {
                ProcessInput(numint);
            }
            else if (double.TryParse(enter, out numdouble))
            {
                ProcessInput(numdouble);
            }
            else { Console.WriteLine("Enter a number please"); }
        }
    }
    class Program
    {


        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a number:");
                string enter = Console.ReadLine();
                Processor first = new Processor(enter);
            }
        }
    }
}
