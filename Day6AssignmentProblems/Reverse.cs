using System;
using System.Collections.Generic;
using System.Text;

namespace Day6AssignmentProblems
{
    internal class Reverse
    {
        public void ReverseNumber()
        {
            int num, temp, remainder, reverse = 0;
            Console.WriteLine("Enter an integer \n");
            num = int.Parse(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num /= 10;
            }
            Console.WriteLine("Given number is = {0}", temp);
            Console.WriteLine("Its reverse is = {0}", reverse);
            Console.ReadLine();
        }
    }
}
