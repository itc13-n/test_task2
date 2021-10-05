using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    interface IEmployeeRepository
    {
        public IEmployee Find(long id);
    }
}
