using System;

namespace DTOModelsLogic
{
    public static class SalaryCalculator
    {
        private static int[] arr = { 1, 1, 1 }; // for const 

        /// <summary>
        /// Calculates salary for particular employee on specified date
        /// </summary>
        /// <param name="year">Date to calculate salary on</param>
        /// <param name="employmentDate">Date of employment</param>
        /// <param name="initialWageRate">Initial wage rate. Assuming yearly</param>
        /// <param name="maxWageRateInc">Max % of initial wage rate that can be applied to increase it (0.3, 0.5, etc)</param>
        /// <param name="yearWageRateInc">% of wage rate applied to increase it for each year of service (0.3, 0.5, etc)</param>
        /// <returns>Wage rate on specified date as double</returns>
        public static double GetWageRate(DateTime year,
                                         DateTime employmentDate,
                                         double initialWageRate,
                                         double maxWageRateInc,
                                         double yearWageRateInc,
                                         double subordinatesWageRate)
        {
            DateTime zeroYear = new(1, 1, 1);
            TimeSpan timeSpan = year - employmentDate;
            int resYears = (zeroYear + timeSpan).Year - 1;
            double calculatedWageRate = (initialWageRate * (1 + yearWageRateInc)) * Math.Pow((1 + yearWageRateInc), resYears);
            double maxPossibleWageRate = initialWageRate * (1 + maxWageRateInc);


            if (calculatedWageRate > maxPossibleWageRate)
            {
                calculatedWageRate = maxPossibleWageRate;
            }

            calculatedWageRate += subordinatesWageRate;

            return calculatedWageRate;

        }


    }
}
