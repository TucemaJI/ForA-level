using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter the Date");
                string text = Console.ReadLine();
                int delay = 0;
                DateTime.TryParse(text, out DateTime date);

                switch (date.DayOfWeek)
                {
                    case (DayOfWeek.Monday):
                        {
                            delay = 2; break;
                        }
                    case (DayOfWeek.Tuesday):
                        {
                            delay = 3; break;
                        }
                    case (DayOfWeek.Wednesday):
                        {
                            delay = 0; break;
                        }
                    case (DayOfWeek.Thursday):
                        {
                            delay = 6; break;
                        }
                    case (DayOfWeek.Friday):
                        {
                            delay = 5; break;
                        }
                    case (DayOfWeek.Saturday):
                        {
                            delay = 4; break;
                        }
                    default:
                        {
                            throw new Exception("Sunday is a day off");
                        }
                }
                DateTime processing = date.AddDays(delay);
                TimeSpan delivering = processing - date;

                Console.WriteLine($"It is {date.DayOfWeek} " +
                    $"and deliver is {delivering.Days} days " +
                    $"and it will be {processing.Date}.");
            }
        }
    }
}
