using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cashmachine = new Cashmachine();
            bool exit = false;
            int isEnter = -1;
            while (isEnter <= 0)
            {
                isEnter = cashmachine.CheckIDPass();
            }
            while (!exit)
            {
                if (isEnter > 0)
                {
                    char ex = cashmachine.GetMoney(isEnter);
                    if (ex == 'q')
                    {
                        exit = true;
                    }
                }
                else if (isEnter == 0)
                {
                    exit = cashmachine.GetChoise(isEnter);
                }
            }
        }
    }
}
