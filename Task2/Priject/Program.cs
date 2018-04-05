using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priject
{
    class Program
    {
        static void Main(string[] args)
        {
            double km = 10;
            int day = 1;
            do
            {
                day += 2;
                km += km / 10;
                Console.WriteLine(day + " Days " + km + " kilometers");
            } while (km <= 100);
            Console.ReadLine();
            //For what I need '%' ?
        }
    }
}
