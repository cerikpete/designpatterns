using System;

namespace DuckLibrary.Ducks
{
    public class DuckDecoy : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("I'm just a decoy!  I'm silent!");
        }

        public string Name { get; set; }
    }
}