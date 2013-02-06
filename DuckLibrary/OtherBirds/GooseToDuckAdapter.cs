using System;
using DuckLibrary.Ducks;
using Geese;

namespace DuckLibrary.OtherBirds
{
    public class GooseToDuckAdapter : IQuackable
    {
        private readonly Goose gooseToAdapt;

        public GooseToDuckAdapter(Goose gooseToAdapt)
        {
            this.gooseToAdapt = gooseToAdapt;
        }

        public void Quack()
        {
            Console.WriteLine(gooseToAdapt.Honk());
        }

        public string Name { get; set; }
    }
}