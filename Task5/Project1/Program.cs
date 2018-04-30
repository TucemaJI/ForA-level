using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Massive
    {
        private readonly int[] _array;

        public int Length
        {
            get { return _array.Length; }
        }

        public int this[int element]
        {
            get { return _array[element]; }
            set { _array[element] = value; }
        }

        public Massive(int length)
        {
            _array = new int[length];
        }

        public int Average(int k)
        {
            int sum = 0, minsum = 0;
            int count = 0;

            foreach (var element in _array)
            {
                if (k > 0 && element > k)
                {
                    sum += element;
                    count++;
                }
                else if (k <= 0 && element < k)
                {
                    minsum += element;
                    count++;
                }
                else { Console.WriteLine("No 'if' or 'else if' in the Average"); }
            }
            if (count <= 0) { return 0; }
            else if (k <= 0) { return minsum; }
            else return (sum / count);
        }
    }

    class Program
    {       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your array size:");
            int size = GetArraySize();
            Massive massive = new Massive(size);
            Console.WriteLine("Please fill your array:");
            FillArray(massive);
            Console.WriteLine("Please enter K:");
            int k = ReadInt32();
            int value = massive.Average(k);
            Console.WriteLine("Value: {0}", value);
            massive[0] = value;
            Console.WriteLine("The first element of an array: {0}", massive[0]);
            Console.ReadLine();
        }


        private static int GetArraySize()
        {
            int size;
            
            while ((size = ReadInt32()) < 1)
                Console.WriteLine("Error. The value must be greater or equal to 1...");

            return size;
        }

        private static void FillArray(Massive massive)
        {
            for (int i = 0; i < massive.Length; i++)
            {
                Console.WriteLine("Enter " + i + " element of massive:");
                massive[i] = ReadInt32();
            }
        }

        private static int ReadInt32()
        {
            int result;

            while (!int.TryParse(Console.ReadLine(), out result))
                Console.WriteLine($"Error. Min value: {int.MinValue}, Max value: {int.MaxValue}. Try again...");

            return result;
        }
    }
}
