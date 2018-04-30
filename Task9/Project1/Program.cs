using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program : Game
    {
        public static short[] playersChoises = new short[32767];
        static void Main(string[] args)
        {
            StartPage();
            byte round = 0;
            short num = 0;
            ZealousPlayer zealousPlayer = new ZealousPlayer { Name = "First player" };
            SimplePlayer simplePlayer = new SimplePlayer { Name = "Second player" };
            SimpleCleverPlayer simpleCleverPlayer = new SimpleCleverPlayer { Name = "Thirst player" };
            ZealousCheater zealousCheater = new ZealousCheater { Name = "Fourth player" };
            SimpleCheater simpleCheater = new SimpleCheater { Name = "Fifth player" };
            while (playersChoises[num] != guessNumber)
            {

                Console.WriteLine("This is the {0} round", ++round);

                playersChoises[++num] = zealousPlayer.DoChoise();
                if (Winner(playersChoises[num], zealousPlayer.Name) == true) { return; }
                Console.WriteLine(zealousPlayer.Name + playersChoises[num]);

                playersChoises[++num] = simplePlayer.DoChoise();
                if (Winner(playersChoises[num], simplePlayer.Name) == true) { return; }
                Console.WriteLine(simplePlayer.Name + playersChoises[num]);

                playersChoises[++num] = simpleCleverPlayer.DoChoise();
                if (Winner(playersChoises[num], simpleCleverPlayer.Name) == true) { return; }
                Console.WriteLine(simpleCleverPlayer.Name + playersChoises[num]);

                playersChoises[++num] = zealousCheater.DoChoise();
                if (Winner(playersChoises[num], zealousCheater.Name) == true) { return; }
                Console.WriteLine(zealousCheater.Name + playersChoises[num]);

                playersChoises[++num] = simpleCheater.DoChoise();
                if (Winner(playersChoises[num], simpleCheater.Name) == true) { return; }
                Console.WriteLine(simpleCheater.Name + playersChoises[num]);

                Console.ReadLine();
            }
        }
        private static bool Winner(short value, string player)
        {
            if (value == guessNumber)
            {
                Console.WriteLine("{0} has won", player);
                Console.ReadLine();
                return true;
            }
            return false;
        }
    }
}
