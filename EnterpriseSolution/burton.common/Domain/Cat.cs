namespace burton.common.Domain
{
    public class Cat : Animal
    {
        public override string MakeNoise()
        {
            return "meow";
        }

        public Cat()
        {
            Importance = Importance.Critical;
        }
    }
}
