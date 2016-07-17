using System.Collections.Generic;

namespace burton.common.Domain
{
    public class Enclosure :DomainBase
    {
        public List<Animal> Animals { get; set; }

        public Enclosure()
        {
            Animals = new List<Animal>();
        }
    }
}
