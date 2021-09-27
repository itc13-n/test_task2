using System;
using System.Collections.Generic;
using System.Text;

namespace DTO_Models
{
    public interface IWorker
    {
        string Name { get; set; }
        DateTime EmploymentDate { get; set; }
        int Group { get; set; }
        double WageRate { get; set; }

        public double GetSalary(DateTime year);
    }
}
