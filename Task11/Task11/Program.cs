using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<byte, string> People = new SortedList<byte, string>();

            for (byte key = 0; key < byte.MaxValue; key++)
            {
                People.Add(key, $"player {key}");
            }

            short count = 1;

            while (true)
            {
                for (byte element = 0; element < (byte)(People.Count); element++, count++)
                {
                    if (count % 2 == 0)
                    {
                        People.RemoveAt(element);
                    }
                }
                foreach (var elem in People)
                {
                    People.TryGetValue(elem.Key, out string val);
                    Console.WriteLine(val);
                }
                Console.ReadLine();
            }
        }
    }
}
