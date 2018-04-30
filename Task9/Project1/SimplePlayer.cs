using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class SimplePlayer:Game,IDoChiose
    {
        public string Name { get; set; }
        public byte DoChoise()
        {
            Random rnd = new Random();
            byte choise = (byte) rnd.Next(minValue, maxValue);
            return choise;
        }
    }
}
