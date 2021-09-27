using System;
using DTOModelsLogic;


namespace DTOModels
{
    public class Employee : IWorker
    {
        public string Name { get; set; }
        public DateTime EmploymentDate { get; set; }
        public int Group { get; set; }
        public IBoss Chief { get; set; }
        public double InitialWageRate { get; set; }
        public double MaxSalaryInc { get; set; }
        public double SalaryIncYear { get; set; }

        public double GetWageRate(DateTime year)
        {
            return SalaryCalculator.GetWageRate(year,
                                                this.EmploymentDate,
                                                this.InitialWageRate,
                                                this.MaxSalaryInc,
                                                this.SalaryIncYear,
                                                subordinatesWageRate: 0);
        }
    }
}
