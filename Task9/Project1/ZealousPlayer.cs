using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class ZealousPlayer:Game, IDoChiose
    {
        public string Name { get; set; }
        public byte DoChoise()
        {
            byte choise = minValue;
            return choise;
        }
    }
}
