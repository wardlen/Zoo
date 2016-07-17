using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burton.common.definitions.interfaces
{
    public interface IAnimal
    {
        int Age { get; set; }

        Importance Importance { get; set; }

        IAnimalHead Head { get; set; }

        IFly Fly { get; set; }
    }
}
