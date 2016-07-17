using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burton.common.definitions.interfaces
{
    public interface IAnimalHead
    {
        IAnimalEye LeftEye { get; set; }
        IAnimalEye RightEye { get; set; }
    }
}
