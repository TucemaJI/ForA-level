using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0;
            double n3;
            bool s1 = false, s2 = false;
            while (!s2)
            {
                while (!s1)
                {
                    try
                    {
                        Console.Write("Enter №1 = ");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter a number");
                        s1 = true;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Enter a less number");
                        s1 = true;
                    }
                }
                while (!s1)
                {
                    try
                    {
                        Console.Write("Enter №2 = ");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter a number");
                        s1 = true;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Enter a less number");
                        s1 = true;
                    }
                }
                if (s1 == false)
                {
                    n3 = (double)n1 / (double)n2;
                    Console.WriteLine("Result = " + n3);
                }
                s1 = false;
            }
        }
    }
}
