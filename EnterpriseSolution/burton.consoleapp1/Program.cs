using burton.common.Domain;
using burton.zooapplication;
using System;

namespace burton.consoleapp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var zooApplication = new ZooApplication();

                var chesterZoo = zooApplication.NewZoo("Chester Zoo");

                zooApplication.LoadZoo(chesterZoo);

                const string londonZooName = "London Zoo";

                var londonZoo = zooApplication.NewZoo(londonZooName);

                var reptileEnclosure = new Enclosure {Name = "Reptile Enclosure"};

                zooApplication.AddEnclosure(londonZoo, reptileEnclosure);

                var sirHiss = new Snake
                {
                    Name = "Sir Hiss",
                    Age = 2
                };

                zooApplication.AddAnimal(reptileEnclosure, sirHiss);

                var zoo2 = zooApplication.GetZoo(londonZooName);

                foreach (var zoo in zooApplication.GetAllZoos())
                {
                    Console.WriteLine("\n++++++++++ Visiting {0}. ++++++++++++", zoo.Name);

                    foreach (var enclosure in zoo.Enclosures)
                    {
                        foreach (var animal in enclosure.Animals)
                        {
                            animal.Fly.DoFly();

                            var detail = string.Format(
                                "{0} likes to {1} and flys {2} feet off the ground.", 
                                animal.Name, 
                                animal.MakeNoise(), 
                                animal.Fly.HeightOffGround);

                            Console.WriteLine(detail);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }
    }
}
