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
            Console.WriteLine("Enter your array size of the first rank:");
            int size1 = Massive.GetArraySize();
            Console.WriteLine("Enter your array size of the second rank:");
            int size2 = Massive.GetArraySize();
            Console.WriteLine("Enter your array size of the third rank:");
            int size3 = Massive.GetArraySize();

            Massive massive = new Massive(size1,size2,size3);

            Console.WriteLine("Please fill your arrays:");
            Massive.FillArrays(massive);
            Console.WriteLine();
            Massive.ShowMassive(massive);
            Console.ReadLine();

        }
    }
}
