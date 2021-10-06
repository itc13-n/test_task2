using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IEmployee
    {
        public List<IEmployee> Subordinates { get; set; }
    }
}
