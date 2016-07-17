using burton.common.definitions.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burton.common
{
    public class CantFly : IFly
    {
        public int HeightOffGround
        {
            get; set;
        }
        public CantFly()
        {
            HeightOffGround = 0;
        }

        public void DoFly()
        {
          
        }
    }
}
