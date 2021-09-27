using DTOModelsLogic;
using System;
using System.Collections.Generic;

namespace DTOModels
{
    public class Salesman : IWorker, IBoss
    {
        public string Name { get; set; }
        public DateTime EmploymentDate { get; set; }
        public int Group { get; set; }
        public IWorker Subordinates { get; set; }
        public double InitialWageRate { get; set; }
        public double MaxSalaryInc { get; set; }
        public double SalaryIncYear { get; set; }
        public double SalaryIncSubordinates { get; set; }

        public double GetWageRate(DateTime year)
        {
            List<IWorker> subordinatesLevel1 = GetSubordinates();

            double subordinatesWageRateSum = 0;

            foreach (IWorker employee in subordinatesLevel1)
            {
                subordinatesWageRateSum += employee.GetWageRate(year);
            }

            subordinatesWageRateSum *= SalaryIncSubordinates;

            return SalaryCalculator.GetWageRate(year: year,
                                                this.EmploymentDate,
                                                this.InitialWageRate,
                                                this.MaxSalaryInc,
                                                this.SalaryIncYear,
                                                subordinatesWageRate: subordinatesWageRateSum);
        }

        public List<IWorker> GetSubordinates()
        {
            throw new NotImplementedException();
        }
    }
}
