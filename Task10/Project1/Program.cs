using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            GameLife life = new GameLife();
            life.FillField();
            life.SetPoints();
            int live_points;
            bool repeat;

            do
            {
                life.Show();
                life.Copy();
                life.Round();

                repeat = life.Compare();
                live_points = life.IsLive();

                if (repeat == true)
                {
                    Console.WriteLine("Life is optimal");
                }
                if (live_points == 0)
                {
                    Console.WriteLine("Everyone is dead");
                }
                Console.ReadLine();
            } while (live_points != 0 && !repeat);
            Console.ReadLine();
        }
    }
}
