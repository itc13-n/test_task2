using System;

namespace DTOModelsLogic
{
    public static class SalaryCalculator
    {
        /// <summary>
        /// Calculates salary for particular employee on specified date
        /// </summary>
        /// <param name="year">Date to calculate salary on</param>
        /// <param name="employmentDate">Date of employment</param>
        /// <param name="initialWageRate">Initial wage rate. Assuming yearly</param>
        /// <param name="maxWageRateBonus">Max % of initial wage rate that can be applied to increase it (0.3, 0.5, etc)</param>
        /// <param name="yearWageRateBonus">% of wage rate applied to increase it for each year of service (0.3, 0.5, etc)</param>
        /// <returns>Wage rate on specified date as double</returns>
        public static double GetWageRate(DateTime year,
                                         DateTime employmentDate,
                                         double initialWageRate,
                                         double maxWageRateBonus,
                                         double yearWageRateBonus,
                                         double subordinatesWageRateBonus)
        {
            DateTime yearsOfSeviceTotal = year.AddYears(-employmentDate.Year);
            double calculatedWageRate = (initialWageRate * (1 + yearWageRateBonus)) * Math.Pow((1 + yearWageRateBonus), yearsOfSeviceTotal.Year);
            double maxPossibleWageRate = initialWageRate * (1 + maxWageRateBonus);


            if (calculatedWageRate > maxPossibleWageRate)
            {
                calculatedWageRate = maxPossibleWageRate;
            }

            calculatedWageRate += subordinatesWageRateBonus;

            return calculatedWageRate;

        }
    }
}
