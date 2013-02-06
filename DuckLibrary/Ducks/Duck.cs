using System;

namespace DuckLibrary.Ducks
{
    public class Duck
    {
        public void Migrate()
        {
            Console.WriteLine(SetLocation() + " And away I go!");
        }

        public virtual string SetLocation()
        {
            return "I'm heading south";
        }
    }
}