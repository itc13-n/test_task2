using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Models
{
    class Salesman : IWorker, IBoss
    {
        public string Name { get; set; }
        public DateTime EmplDate { get; set; }
        public int Group { get; set; }
        public double WageRate { get; set; }

        /// <summary>
        /// Calculates salary for particular employee on specified date
        /// </summary>
        /// <param name="year">Date to calculate salary on</param>
        /// <returns></returns>
        public double GetSalary(DateTime year)
        {
            DateTime zeroYear = new DateTime(1, 1, 1);
            TimeSpan timeSpan = year - EmplDate;
            int resYears = (zeroYear + timeSpan).Year - 1;
            double salary = (WageRate * 1.01) * Math.Pow(1.01, resYears);
            double max = WageRate * 1.35;
            if (salary > max)
            {
                salary = max;
            }

            List<IWorker> subordinates = this.GetSubordinates();
            double sum = 0;
            foreach (IWorker subordinate in subordinates)
            {
                sum += subordinate.GetSalary(DateTime.Now);
            }
            return salary + sum * 0.3;
        }

        public List<IWorker> GetSubordinates()
        {
            throw new NotImplementedException();
        }
    }
}
