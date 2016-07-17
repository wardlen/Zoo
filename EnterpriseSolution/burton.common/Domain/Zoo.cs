using System.Collections.Generic;

namespace burton.common.Domain
{
   public class Zoo : DomainBase
    {
        public List<Enclosure> Enclosures { get; set; }

        public Zoo()
        {
            Enclosures = new List<Enclosure>();
        }
    }
}
