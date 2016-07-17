using burton.common.definitions.interfaces;

namespace burton.common.Domain
{
    public class AnimalHead : IAnimalHead
    {
        public AnimalHead()
        {
            LeftEye = new AnimalEye { EyeColour = "Blue" };
            RightEye = new AnimalEye { EyeColour = "Brown" };
        }

        public IAnimalEye LeftEye { get; set; }
        public IAnimalEye RightEye { get; set; }
    }
}
