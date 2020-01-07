using System;

namespace Project1
{
    class Rectangle
    {
        int h = 0;
        int w = 0;

        public Rectangle(int h, int w)
        {
            this.h = h;
            this.w = w;
        }
        public void S()
        {
            try
            {
                int S = h * w;
                Console.WriteLine("Your h = " + h);
                Console.WriteLine("Your w = " + w);
                Console.WriteLine("Your S = " + S);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Enter a less number");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Write your h = ");
                    int h = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Write your w = ");
                    int w = Convert.ToInt32(Console.ReadLine());
                    Rectangle R1 = new Rectangle(h, w);
                    R1.S();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter a number next time");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Enter a less number next time");
                }
            }
        }
    }
}
