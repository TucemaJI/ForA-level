using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class SimpleCleverPlayer : Game, IDoChiose
    {
        public string Name { get; set; }
        private byte[] choises = new byte[maxValue];
        public byte DoChoise()
        {
            Random rnd = new Random();
            byte choise = (byte)rnd.Next(minValue, maxValue);
            for (byte i = 0; i < choises.Length; i++)
            {
                if (choises[i] == choise)
                {
                    choise = (byte)rnd.Next(minValue, maxValue);
                    i = 0;
                }
            }
            for (byte i = 0; i < choises.Length; i++)
            {
                if (choises[i] == 0)
                {
                    choises[i] = choise;
                }
            }
            return choise;
        }
    }
}
