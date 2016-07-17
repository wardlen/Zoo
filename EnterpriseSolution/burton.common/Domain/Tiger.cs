using burton.common.definitions.interfaces;

namespace burton.common.Domain
{
    public class Tiger : Animal
    {
        public Tiger()
        {
            Age = 7;

            Head.LeftEye.EyeColour = "Gold";

            Dance = new CantDance();
         
        }

        public IDance Dance { get; set; }



        public override string MakeNoise()
        {
            //  return base.MakeNoise();
            return "roar";
        }
    }
}
