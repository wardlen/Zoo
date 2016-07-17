using burton.common.definitions.interfaces;

namespace burton.common.Domain
{
    public abstract class Animal : DomainBase, IAnimal
    {
        public abstract string MakeNoise();

        public int Age { get; set; }

        public Importance Importance { get; set; }

        public IAnimalHead Head { get; set; }

        public IFly Fly { get; set; }

        public Animal()
        {
            Head = new AnimalHead();
            Fly = new CantFly();
            Importance = Importance.None;
        }
    }

}
