using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class ZealousCheater:Game, IDoChiose
    {
        public string Name { get; set; }
        public byte DoChoise()
        {
            byte choise = ++minValue;

            for (short i=0;i< Program.playersChoises.Length;i++ )
            {
                if (Program.playersChoises[i] == choise)
                {
                    i = 0;choise++;
                }
            }
            return choise;
        }
    }
}
