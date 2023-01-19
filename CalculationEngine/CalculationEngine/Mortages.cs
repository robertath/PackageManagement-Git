using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationEngine
{
    public class Mortages : IMortageCalculations
    {
        public double MortageMaximum(double yearIncome, double homeValue)
        {
            var maximum = 4.2 * yearIncome;
            if(maximum > homeValue)
            {
                maximum = homeValue * .8;
            }
            return maximum;
        }

        public double MortageRepaymentSummary(double homeValue, double loanAmount, double interestRate, int termInYears)
        {
            double total = 0;
            double depreciation = loanAmount / termInYears;
            double interestPerYear = loanAmount * interestRate;

            for(int year=0; year<termInYears; year++)
            {
                total += depreciation + interestPerYear;
                total += total * interestRate;
            }

            return total;
        }
    }
}
