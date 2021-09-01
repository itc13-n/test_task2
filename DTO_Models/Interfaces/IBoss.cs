using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Models
{
    interface IBoss
    {
        public abstract List<IWorker> GetSubordinates();
    }
}
