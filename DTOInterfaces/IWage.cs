using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOInterfaces
{
    public interface IWage
    {
        public double BonusYear { get; set; }
        public double BonusSubordinates { get; set; }
    }
}
