using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOModels
{
    public interface IBoss
    {
        double SalaryIncSubordinates { get; set; }

        public List<IWorker> GetSubordinates();
    }
}
