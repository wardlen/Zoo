using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burton.common.Domain
{
    public class Horse : Animal
    {
        public override string MakeNoise()
        {
            return "nay";
        }
    }
}
