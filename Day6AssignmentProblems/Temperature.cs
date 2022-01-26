using System;
using System.Collections.Generic;
using System.Text;

namespace Day6AssignmentProblems
{
    internal class Temperature
    {
        public void Temp()
        {
            double fahrenheit, celsius;
            Console.WriteLine(" To convert Fahrenheit to celsius ");
            Console.WriteLine("Enter a temparature Fahrenheit:");
            double f = Convert.ToDouble(Console.ReadLine());
            celsius = (f - 32)*5/9;
            Console.WriteLine("celsius temaparature :" + celsius);
            Console.WriteLine("To convert celsius to Fahrenheit :");
            Console.WriteLine(" Enter a temparature  celcious :");
            double c = Convert.ToDouble(Console.ReadLine());
            fahrenheit = (c * 9 / 5) + 32;
            Console.WriteLine("Fahrenheit temparature :" + fahrenheit);
        }
    }
}
