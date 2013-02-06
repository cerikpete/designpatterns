using System;
using DuckLibrary.Ducks;

namespace DuckLibrary.Observers
{
    public class UptightDuck : IQuackable, IObserver
    {
        public void Quack()
        {
            Console.WriteLine("quack");
        }

        public void Update(IFarmer farmer)
        {
            Console.WriteLine("UptightDuck says: The current farmer is: " + farmer.Name);
            if (farmer.IsStrict)
            {
                Console.WriteLine("Phew, Bill is here, now I can study");
            }
            else
            {
                Console.WriteLine("Uh oh, PartyAnimalDuck is gonna cause trouble now");
            }
        }

        public string Name { get; set; }
    }
}