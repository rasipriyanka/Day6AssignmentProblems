using System;
using System.Collections.Generic;
using System.Text;

namespace Day6AssignmentProblems
{
    internal class Week
    {

        public void DayWeek()
        {
            Console.WriteLine("Enter year :");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month :");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Day :");
            int d = Convert.ToInt32(Console.ReadLine());
            int y1, x, m1, d1;
            y1 = y - (14 - m) / 12;
            x = y1 + (y1 / 4) - (y1 / 100) + (y1 / 400);
            m1=m+12*((14-m) / 12)-2;
            d1=(d+x+31*m1/12)% 7;

            switch (d1) // based on d1 value the block of statements executed
            {
                case 0:
                    Console.WriteLine("sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("saturday");
                    break;
            }
        }
    }
}
