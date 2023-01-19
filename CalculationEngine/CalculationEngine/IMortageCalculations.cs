namespace CalculationEngine
{
    public interface IMortageCalculations
    {
        double MortageRepaymentSummary(double homeValue, double loanAmount, double interestRate, int termInYears);
        double MortageMaximum(double yearIncome, double homeValue);
    }
}