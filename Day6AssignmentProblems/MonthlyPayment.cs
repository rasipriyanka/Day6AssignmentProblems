using System;
using System.Collections.Generic;
using System.Text;

namespace Day6AssignmentProblems
{
    internal class MonthlyPayment
    {
        public void Monthly()
        {
            int loanAmount = 10000;
            double interest = 5.0;
            int numberOfYears = 5;

            // rate of interest and number of payments for monthly payments
            double rateOfInterest = interest / 12 *100;
            double numberOfPayments = numberOfYears * 12;

            // loan amount = (interest rate * loan amount) / (1 - (1 + interest rate)^(number of payments * -1))
            double paymentAmount = (rateOfInterest * loanAmount) / (1 - Math.Pow(1 + rateOfInterest, numberOfPayments * -1));

            Console.WriteLine("The Total Payment {0} with {1} intrest per month in {2} years is {3} ", loanAmount, interest, numberOfYears, paymentAmount);
        }
    }
}
