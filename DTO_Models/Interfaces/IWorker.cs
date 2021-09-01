using System;
using System.Collections.Generic;
using System.Text;

namespace DTO_Models
{
    interface IWorker
    {
        string Name { get; set; }
        DateTime EmplDate { get; set; }
        int Group { get; set; }
        double WageRate { get; set; }

        public abstract double GetSalary(DateTime year);
    }
}
