using Contracts;

namespace EmployeeRepository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        IEmployee IEmployeeRepository.Find(long id)
        {
            throw new System.NotImplementedException();
        }
    }
}
