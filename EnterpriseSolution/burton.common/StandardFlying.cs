using burton.common.definitions.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burton.common
{
    public class StandardFlying : IFly
    {
        public int HeightOffGround
        {
            get; set;
        }

        public void DoFly()
        {
            // i asm flapping
            HeightOffGround = 50;
        }
    }
}
