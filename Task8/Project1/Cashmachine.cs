using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Cashmachine : ICashmachine
    {
        private string[,] _users = new string[7, 3];

        private void Admin()
        {
            _users[0, 0] = "Admin";
            _users[0, 1] = "admin";
            _users[0, 2] = "100000";
        }
        private void Users()
        {
            for (int i = 1; i < 7; i++)
            {
                _users[i, 2] = "10000";
            }
            _users[1, 0] = "Vasya";
            _users[1, 1] = "vas11";
            _users[2, 0] = "Gosha";
            _users[2, 1] = "gosh1233";
            _users[3, 0] = "Gadya";
            _users[3, 1] = "gad66";
            _users[4, 0] = "Petrovich";
            _users[4, 1] = "pet2134";
            _users[5, 0] = "Hrenovo";
            _users[5, 1] = "hren11";
            _users[6, 0] = "Vova";
            _users[6, 1] = "vov33";
        }
        public string GetUser(int row, int str)
        {
            return _users[row, str];
        }
        public Cashmachine()
        {
            Admin(); Users();
        }

        public int CheckIDPass()
        {
            Console.WriteLine("Enter your ID");
            string checkid = Console.ReadLine();
            for (int i = 0; i < _users.Length / 3; i++)
            {
                if (_users[i, 0] == checkid)
                {
                    byte tryes = 3;
                    Console.WriteLine("Enter your Password");
                    string checkpass = Console.ReadLine();
                    if (_users[i, 1] == checkpass)
                    { return i; }
                    while (_users[i, 1] != checkpass && tryes != 0)
                    {
                        Console.WriteLine("You have entered the different password, you have only {0} tryes", tryes);
                        tryes--;
                        Console.WriteLine("Enter your Password");
                        checkpass = Console.ReadLine();
                        if (_users[i, 1] == checkpass)
                        { return i; }
                    }
                    if (tryes == 0)
                    {
                        for (; i > 0 && i < 6; i++)
                        {
                            _users[i, 0] = _users[i + 1, 0];
                            _users[i, 1] = _users[i + 1, 1];
                            _users[i, 2] = _users[i + 1, 2];

                            if (_users[i, 0] == null)
                            {
                                Array.Clear(_users, i * 3, 3);
                                break;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("You have been written the different password or account");
            return -1;
        }
        public char GetMoney(int i)
        {
            Console.WriteLine("Please enter that quantity of money, what you need for taking.");
            Console.WriteLine("Enter q for exit");
            
            string result = Console.ReadLine();
            Char.TryParse(result, out char ex);
            if (ex == 'q')
            {
                return ex;
            }
            int money = 0;
            try
            {
                money = Int32.Parse(result);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Enter less money 'majorchik'");
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter the number next time");
            }
            Int32.TryParse(_users[i, 2], out int account);
            if (account >= money)
            {
                account -= money;
                account.ToString(_users[i, 2]);
                return 'n';
            }
            else
            {
                Console.WriteLine("Not enough money. Go work.");
                return 'n';
            }
        }
        public bool GetChoise(int accChosen)
        {
            int account = 0;
            bool exit = false;
            Console.WriteLine("Choose that number, what you need, greatest admin");
            Console.WriteLine("1 - Add new account");
            Console.WriteLine("2 - Show accounts");
            Console.WriteLine("3 - Delete account");
            Console.WriteLine("Another number - Exit");
            Int32.TryParse(Console.ReadLine(), out int choise);
            switch (choise)
            {
                case 1:
                    account = AccountAdd();
                    break;

                case 2:
                    for (int i = 0; i < 7; i++)
                    {
                        if (GetUser(i, 0) != null)
                        {
                            Console.WriteLine($"№{i}\t{GetUser(i, 0)}\t{GetUser(i, 1)}\t{GetUser(i, 2)}");
                        }
                    }
                    break;

                case 3:
                    AccountDelete();
                    break;

                case 4:
                    GetMoney(accChosen);
                    break;

                default:
                    exit = true;
                    break;
            }
            return exit;
        }
        private int AccountAdd()
        {
            Console.WriteLine("Choose numer for account");
            Int32.TryParse(Console.ReadLine(), out int accountAdd);
            if (_users[accountAdd, 0] == null)
            {
                Console.WriteLine($"Enter new ID");
                _users[accountAdd, 0] = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No place for new account");
                return accountAdd;
            }
            Console.WriteLine($"Enter the password");
            _users[accountAdd, 1] = Console.ReadLine();

            Console.WriteLine("Enters start cash");
            int result = 0;
            try
            {
                result = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter the number next time");
            }
            result.ToString(_users[accountAdd, 2]);
            accountAdd++;

            return accountAdd;
        }
        private void AccountDelete()
        {
            Console.WriteLine("Csoose № for delete");
            Int32.TryParse(Console.ReadLine(), out int calculation);
            if (_users[calculation, 2] == null)
            {
                Array.Clear(_users, calculation * 3, 3);
                for (; calculation < 6; calculation++)
                {
                    _users[calculation, 0] = _users[calculation + 1, 0];
                    _users[calculation, 1] = _users[calculation + 1, 1];
                    _users[calculation, 2] = _users[calculation + 1, 2];

                    if (_users[calculation, 0] == null)
                    {
                        Array.Clear(_users, calculation * 3, 3);
                        break;
                    }
                }
            }
            else { Console.WriteLine("This account with money, sorry, but you cat't delete it."); }
        }
    }
}
