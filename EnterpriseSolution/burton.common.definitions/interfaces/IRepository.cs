using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burton.common.definitions.interfaces
{
    public interface IRepository
    {
        IAnimal Get(int Id);

        List<IAnimal> GetAll();

        int Add(IAnimal animal);

        void Update(IAnimal animal);

        void Submit();
    }
}
