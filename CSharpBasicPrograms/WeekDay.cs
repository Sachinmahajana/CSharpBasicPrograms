using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicPrograms
{
    internal class WeekDay
    {
        public static void FindDayWhichFallsOnWeek(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Its'a Monday");
                    break;
                case 2:
                    Console.WriteLine("Its'a Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Its'a Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Its'a Thursday");
                    break;
                case 5:
                    Console.WriteLine("Its'a Friday");
                    break;
                case 6:
                    Console.WriteLine("Its'a Saturday");
                    break;
                case 7:
                    Console.WriteLine("Its'a Sunday");
                    break;
                default:
                    Console.WriteLine("Please choose a number between 1 to 7");
                    break;
            }

        }

    }

}
    

