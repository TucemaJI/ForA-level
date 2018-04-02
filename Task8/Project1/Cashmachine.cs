using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Cashmachine : IStart
    {
        private string[,] users = new string[6, 3];

        private void Admin()
        {
            users[0, 0] = "Admin";
            users[0, 1] = "admin";
            users[0, 2] = "100000";
        }
        private void Users()
        {
            for (int i = 1; i < 6; i++)
            {
                users[i, 2] = "10000";
            }
            users[1, 0] = "Vasya";
            users[1, 1] = "vas11";
            users[2, 0] = "Gosha";
            users[2, 1] = "gosh1233";
            users[3, 0] = "Gadya";
            users[3, 1] = "gad66";
            users[4, 0] = "Petrovich";
            users[4, 1] = "pet2134";
            users[5, 0] = "Hrenovo";
            users[5, 1] = "hren11";
            //users[6, 0] = "Vova";
            //users[6, 1] = "vov33";
        }
        public void Cashmach()
        {
            Admin(); Users();
            bool exit = false;
            int account = 0;

            int isEnter = CheckIDPass();
            if (isEnter > 0)
            {
                while (!exit)
                {
                    GetMoney(isEnter);
                    Console.WriteLine("Enter 1 for exit");
                    Byte.TryParse(Getting(), out byte ex);
                    if (ex == 1)
                    {
                        exit = true;
                    }
                }

            }
            else if (isEnter == 0)
            {
                while (!exit)
                {
                    int choise = GetChoise();
                    switch (choise)
                    {
                        case 1:
                            account = AccountAdd();
                            break;

                        case 2:
                            for (int i = 0; i < 6; i++)
                            {
                                if (users[i, 0] != null)
                                {
                                    Console.WriteLine($"№{i}\t{users[i, 0]}\t{users[i, 1]}\t{users[i, 2]}");
                                }
                            }
                            break;

                        case 3:
                            AccountDelete();
                            account--;
                            break;

                        case 4:
                            GetMoney(isEnter);
                            break;

                        default:
                            exit = true;
                            break;
                    }
                }

            }

        }
        private string Getting()
        {
            string getting = Console.ReadLine();
            return getting;
        }
        private int CheckIDPass()
        {
            Console.WriteLine("Enter your ID");
            string checkid = Getting();
            for (int i = 0; i <= users.Length / 3; i++)
            {
                if (users[i, 0] == checkid)
                {
                    byte tryes = 3;
                    Console.WriteLine("Enter your Password");
                    string checkpass = Getting();
                    if (users[i, 1] == checkpass)
                    { return i; }
                    while (users[i, 1] != checkpass && tryes != 0)
                    {
                        Console.WriteLine("You have entered the different password, you have only {0} tryes", tryes);
                        tryes--;
                        Console.WriteLine("Enter your Password");
                        checkpass = Getting();
                        if (users[i, 1] == checkpass)
                        { return i; }
                    }
                    if (tryes == 0)
                    {
                        for (; i > 0 && i < 6; i++)
                        {
                            users[i, 0] = users[i + 1, 0];
                            users[i, 1] = users[i + 1, 1];
                            users[i, 2] = users[i + 1, 2];

                            if (users[i, 0] == null)
                            {
                                Array.Clear(users, i * 3, 3);
                                break;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("You have been written the different password or account");
            return -1;
        }
        private void GetMoney(int i)
        {
            Console.WriteLine("Please enter that quantity of money, what you need for taking.");
            int result = 0;
            try
            {
                result = Int32.Parse(Getting());
            }
            catch (OverflowException)
            {
                Console.WriteLine("Enter less money 'majorchik'");
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter the number next time");
            }
            Int32.TryParse(users[i, 2], out int account);
            if (account >= result)
            {
                account = account - result;
                account.ToString(users[i, 2]);
            }
            else
            {
                Console.WriteLine("Not enough money. Go work.");
            }
        }
        private int GetChoise()
        {
            Console.WriteLine("Choose that number, what you need, greatest admin");
            Console.WriteLine("1 - Add new account");
            Console.WriteLine("2 - Show accounts");
            Console.WriteLine("3 - Delete account");
            Console.WriteLine("Another number - Exit");
            Int32.TryParse(Console.ReadLine(), out int choise);
            return choise;
        }
        private int AccountAdd()
        {
            Console.WriteLine("Choose numer for account");
            Int32.TryParse(Console.ReadLine(), out int account_add);
            if (users[account_add, 0] == null)
            {
                Console.WriteLine($"Enter new ID");
                users[account_add, 0] = Getting();
            }
            else
            {
                Console.WriteLine("No place for new account");
                return account_add;
            }
            Console.WriteLine($"Enter the password");
            users[account_add, 1] = Getting();

            Console.WriteLine("Enters start cash");
            int result = 0;
            try
            {
                result = Int32.Parse(Getting());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter the number next time");
            }
            result.ToString(users[account_add, 2]);
            account_add++;

            return account_add;
        }
        private void AccountDelete()
        {
            Console.WriteLine("Csoose № for delete");
            Int32.TryParse(Console.ReadLine(), out int calculation);
            if (users[calculation, 2] == null)
            {
                Array.Clear(users, calculation * 3, 3);
                for (; calculation < 6; calculation++)
                {
                    users[calculation, 0] = users[calculation + 1, 0];
                    users[calculation, 1] = users[calculation + 1, 1];
                    users[calculation, 2] = users[calculation + 1, 2];

                    if (users[calculation, 0] == null)
                    {
                        Array.Clear(users, calculation * 3, 3);
                        break;
                    }
                }
            }
            else { Console.WriteLine("This account with money, sorry, but you cat't delete it."); }
        }


    }
}
