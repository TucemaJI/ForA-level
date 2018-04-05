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
            GameLife life = new GameLife();
            int live_points = -1;
            bool repeat = false;
            life.FillField();
            life.SetPoints();
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
