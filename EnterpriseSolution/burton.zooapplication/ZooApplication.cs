using burton.common;
using burton.common.Domain;
using burton.zooapplication.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burton.zooapplication
{
    public class ZooApplication
    {
        private readonly List<Zoo> _zoos;

        public ZooApplication()
        {
            _zoos = new List<Zoo>();
        }

        public Zoo NewZoo(string name)
        {
            var zoo = new Zoo {Name = name};

            _zoos.Add(zoo);

            return zoo;
        }

        public List<Zoo> GetAllZoos()
        {
            return this._zoos;
        }

        public Zoo GetZoo(string name)
        {
            return this._zoos.SingleOrDefault(z => z.Name.Equals(name));
        }

        public void AddEnclosure(Zoo zoo, Enclosure enclosure)
        {
            zoo.Enclosures.Add(enclosure);
        }

        public void AddAnimal(Enclosure enclosure, Animal animal)
        {
            enclosure.Animals.Add(animal);
        }

        public void LoadZoo(Zoo zoo)
        {
            //var zero = 0;

            //var badNumber = 1 / zero;

            var horseEnclosure = new Enclosure();

            var batEnclosure = new Enclosure();

            var felineEnclosure = new Enclosure();

            zoo.Enclosures.Add(batEnclosure);

            zoo.Enclosures.Add(felineEnclosure);

            zoo.Enclosures.Add(horseEnclosure);

            var tiddles = new Cat
            {
                Name = "Tiddles the cat",
                Age = 2
            };

            var noise = tiddles.MakeNoise();

            var stripes = new Tiger
            {
                Name = "stripes",
                Dance = new Foxtrot()
            };

            stripes.Dance = new Jive();

            var bluebat = new Bat() { Name = "batty" };

            bluebat.Fly.DoFly();

            felineEnclosure.Animals.Add(tiddles);

            felineEnclosure.Animals.Add(stripes);

            // 4 x linq queries

            var critcalAnimals = felineEnclosure.Animals.Where(a => a.Importance.Equals(Importance.Critical));

            var oldAnimals = felineEnclosure.Animals.Where(a => a.Age > 1);

            var myTiger =  felineEnclosure.Animals.Single(a => a.Name.Equals("stripes"));

            var myTiger2 = felineEnclosure.Animals.First(a => a.Name.Equals("stripes"));

            // ++++++++++++++++++++

            batEnclosure.Animals.Add(bluebat);

            var pegasus = new Horse
            {
                Id = 6,
                Name = "Pegasus",
                Fly = new StandardFlying()
            };


            pegasus.Fly.DoFly();

            var neddy = new Horse { Name = "Neddy" };

            horseEnclosure.Animals.Add(pegasus);

            horseEnclosure.Animals.Add(neddy);

            // allows us to save pegasus object to back end - database
            var myRepository = new FakeRepository();

            myRepository.Add(pegasus);

            myRepository.Submit();

            // we can get pegasus from back end database
            var peg = myRepository.Get(6);
        }

    }

}
