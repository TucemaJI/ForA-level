using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Massive
    {
        private int[,,] _array;
        public int Length1, Length2, Length3;


        public int this[int element1, int element2, int element3]
        {
            get { return _array[element1, element2, element3]; }
            set { _array[element1, element2, element3] = value; }
        }

        public Massive(int length0, int length1, int length2)
        {
            _array = new int[length0, length1, length2];
            Length1 = length0;
            Length2 = length1;
            Length3 = length2;
        }
        public static int GetArraySize()
        {
            int size;

            while ((size = ReadInt32()) < 1)
                Console.WriteLine("Error. The value must be greater or equal to 1...");

            return size;
        }
        public static void FillArrays(Massive massive)
        {
            for (int i = 0; i < massive.Length1; i++)
            {
                for (int j = 0; j < massive.Length2; j++)
                {
                    for (int k = 0; k < massive.Length3; k++)
                    {
                        Console.WriteLine($"Enter {i},{j},{k} element of massive:");
                        massive[i, j, k] = ReadInt32();
                    }
                }
            }
        }
        public static void ShowMassive(Massive massive)//Average too
        {
            int first = 0, second = 0, third = 0,i,j,k;
            for (i = 0; i < massive.Length1; i++)
            {
                for (j = 0; j < massive.Length2; j++)
                {
                    for (k = 0; k < massive.Length3; k++)
                    {
                        Console.Write($"{massive[i, j, k]} \t");
                        third += massive[i, j, k];
                    }
                    third = third / k;
                    second += massive[i, j,0];
                    Console.WriteLine();
                }
                second = second / j;
                first += massive[i, 0, 0];
                Console.WriteLine();
            }
            first = first / i;
            Console.WriteLine($"First is {first}, second is {second}, third is {third}");
        }
        public static int ReadInt32()
        {
            int result;

            while (!int.TryParse(Console.ReadLine(), out result))
                Console.WriteLine($"Error. Min value: {int.MinValue}, Max value: {int.MaxValue}. Try again...");

            return result;
        }
    }
}
