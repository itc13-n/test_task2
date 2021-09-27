using System;

namespace DTOModels
{
    public interface IWorker
    {
        string Name { get; set; }
        DateTime EmploymentDate { get; set; }
        int Group { get; set; }
        double InitialWageRate { get; set; }
        double MaxSalaryInc { get; set; }
        double SalaryIncYear { get; set; }

        public double GetWageRate(DateTime year);
    }
}
