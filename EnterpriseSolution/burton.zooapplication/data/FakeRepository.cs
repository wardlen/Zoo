using burton.common;
using burton.common.definitions.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using burton.common.Domain;

namespace burton.zooapplication.data
{
    public class FakeRepository : IRepository
    {
        public int Add(IAnimal animal)
        {
            return 1;
        }

        public IAnimal Get(int id)
        {
            return new Cat { Id = id };
        }

        public List<IAnimal> GetAll()
        {
            return new List<IAnimal> { this.Get(0) };
        }

        public void Update(IAnimal animal)
        {
        }

        public void Submit()
        { }
    }
}
