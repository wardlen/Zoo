using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burton.common.definitions.interfaces
{
    public interface IFly
    {
        void DoFly();

        int HeightOffGround { get; set; }
    }
}
