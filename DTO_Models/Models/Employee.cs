using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Models
{
    public class Employee : IWorker
    {
        public string Name { get; set; }
        public DateTime EmploymentDate { get; set; }
        public int Group { get; set; }
        public double WageRate { get; set; }
        public IBoss Chief { get; set; }

        /// <summary>
        /// Calculates salary for particular employee on specified date
        /// </summary>
        /// <param name="year">Date to calculate salary on</param>
        /// <returns></returns>
        public double GetSalary(DateTime year)
        {
            DateTime zeroYear = new DateTime(1, 1, 1);
            TimeSpan timeSpan =  year - EmploymentDate;
            int resYears = (zeroYear + timeSpan).Year - 1;
            double salary = (WageRate * 1.03) * Math.Pow(1.03, resYears);
            double max = WageRate * 1.3;
            if (salary > max)
            {
                return max;
            }
            else
            {
                return salary;
            }
        }
    }
}
