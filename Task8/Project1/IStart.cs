using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    interface ICashmachine
    {
        string GetUser(int row, int str);
        int CheckIDPass();
        char GetMoney(int i);
        bool GetChoise(int account);
    }
}
