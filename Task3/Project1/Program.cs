using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            //double S;
            //double s = 36.79;
            //S = s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s + s;
            //S += s / 1.2658226; //Косыль? Как по-другому?
            int S=0,s=0;
            Console.Write("Enter your number ");
            Int32.TryParse(Console.ReadLine(), out s);
            for (int i = 0;i < s;i++) { S += s; }
            Console.WriteLine("Result "+S);
            Console.ReadLine();
            }
    }
}
