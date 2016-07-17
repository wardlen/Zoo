using burton.common.definitions.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burton.common
{
    public class UpsideDownFlying : IFly
    {
        public int HeightOffGround
        {
            get; set;
        }

        public void DoFly()
        {
            HeightOffGround = -50;
        }
    }
}
