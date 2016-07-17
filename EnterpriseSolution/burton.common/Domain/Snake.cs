namespace burton.common.Domain
{
    public class Snake : Animal
    {
        public override string MakeNoise()
        {
            return "hiss";
        }

        public Snake()
        {
            Importance = Importance.Critical;
        }
    }
}
