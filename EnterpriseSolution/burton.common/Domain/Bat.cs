using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burton.common.Domain
{
    public class Bat: Animal
    {
        public Bat()
        {
            Fly = new StandardFlying();
            Importance = Importance.Regular;
        }

        public override string MakeNoise()
        {
            return "screech";
        }
    }
}
