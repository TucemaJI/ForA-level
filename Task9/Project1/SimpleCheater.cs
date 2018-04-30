using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class SimpleCheater : Game, IDoChiose
    {
        public string Name { get; set; }
        public byte DoChoise()
        {
            Random rnd = new Random();
            byte choise = (byte)rnd.Next(minValue, maxValue);
            for (short i = 0; i < Program.playersChoises.Length; i++)
            {
                if (Program.playersChoises[i] == choise)
                {
                    choise = (byte)rnd.Next(minValue, maxValue);
                    i = 0;
                }
            }
            return choise;
        }
    }
}
