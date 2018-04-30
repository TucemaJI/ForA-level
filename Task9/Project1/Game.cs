using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Game
    {
        protected static byte minValue, maxValue, guessNumber;
        protected static void StartPage()
        {
            Console.WriteLine("Please enter minValue: ");
            minValue = GetSetValue();
            Console.WriteLine("Please enter maxValue: ");
            maxValue = GetSetValue();
            Console.WriteLine("Please enter guessNumber: ");
            guessNumber = GetSetValue();

            byte[] game = new byte[maxValue];
            for (byte i = minValue; i < maxValue; i++)
            {
                game[i] = i;
            }
        }
        private static byte GetSetValue()
        {
            Byte.TryParse(Console.ReadLine(), out byte value);
            return value;
        }
    }
}
