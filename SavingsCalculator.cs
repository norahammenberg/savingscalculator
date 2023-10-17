using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingsCalculator
{
    internal class SavingsCalculator
    {
        // instance variables:
        private double monthlyDeposit = 0.0;
        private double years = 0;
        private double intrestRate = 0.10 / 12;  
        
        /// <summary>
        /// Setters and getters the fetching userinout and returning new values. 
        /// </summary>
        public double gettDeposit()
        {
            return monthlyDeposit;
        }
        public void settDeposit( double newDeposit)
        {
            if (newDeposit > 0.0)
            {
                monthlyDeposit = newDeposit;    
            }
        }
        public double gettYears()
        {
            return years;
        }
        public void settYears(double newYears)
        {
            if (newYears > 0)
            {
                years = newYears;
            }
        }

        /// <summary>
        /// Thiscalculation calculaté tha amount that the users would have paid in the end.
        /// It takes the monthley deposit and times it by 12 (month in ayear) and the times that with amout of years the user have privided:
        /// </summary>
        /// <returns> the value that the user will have paid</returns>
        public double calcAmountPaid()
        {
            //local variable to save the amount paid:
            double amountPaid = 0.0;  

            //doing the calculations for how much the costumer have paid.
            amountPaid = monthlyDeposit * 12 * years;

            //returning the value.
            return amountPaid;
        }
        /// <summary>
        /// this method calculaet the final balance by adding the intrested erned every month. 
        /// By looping through every month and adding every months intredt ernade on the deposit paid.
        /// </summary>
        /// <returns>the final balance </returns>
        public double calcFinalBalance()
        {
            //local variable:
            double finalBalance = 0.0;
            double months = years * 12;
            
            // looping through every month to add erned intrest to the deposit
            for (int i = 0; i < months; i++)
            {
                double ernedInterest = intrestRate * finalBalance;
                finalBalance += ernedInterest + monthlyDeposit;
            }

            //returning the final balance:
            return finalBalance;
        }

    }

  
}
