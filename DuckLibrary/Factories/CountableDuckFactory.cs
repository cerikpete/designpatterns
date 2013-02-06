using DuckLibrary.Decorators;
using DuckLibrary.Ducks;
using DuckLibrary.Factories;

namespace DuckLibrary.Factories
{
    public class CountableDuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateMallardDuck()
        {
            return new QuackCounter(new MallardDuck());
        }

        public override IQuackable CreateRubberDuck()
        {
            return new QuackCounter(new RubberDuck());
        }

        public override IQuackable CreateDuckDecoy()
        {
            return new QuackCounter(new DuckDecoy());
        }
    }
}