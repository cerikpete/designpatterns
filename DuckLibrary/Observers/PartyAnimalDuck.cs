using System;
using DuckLibrary.Ducks;

namespace DuckLibrary.Observers
{
    public class PartyAnimalDuck : IQuackable, IObserver
    {
        public void Quack()
        {
            Console.WriteLine("Quack, man!");
        }

        public void Update(IFarmer farmer)
        {
            Console.WriteLine("PartyAnimalDuck says: The current farmer is: " + farmer.Name);
            if (farmer.IsStrict)
            {
                Console.WriteLine("Uh oh, he is tough, better hide the keg");
            }
            else
            {
                Console.WriteLine("He's cool, pour him a drink!");
            }
        }

        public string Name { get; set; }
    }
}