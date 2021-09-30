using System;
using DTOModelsLogic;


namespace DTOModels
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime EmploymentDate { get; set; }
        public int Group { get; set; }
        //public double InitialWageRate { get; set; } //?
        public int ChiefRef { get; set; }

        public double GetWageRate(DateTime year)
        {
            throw new NotImplementedException();
            //return SalaryCalculator.GetWageRate();
        }
    }
}
