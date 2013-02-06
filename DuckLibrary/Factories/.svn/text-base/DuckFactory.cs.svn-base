using DuckLibrary.Ducks;
using DuckLibrary.Factories;

namespace DuckLibrary.Factories
{
    public class DuckFactory : AbstractDuckFactory
    {
        public override IQuackable CreateMallardDuck()
        {
            return new MallardDuck();
        }

        public override IQuackable CreateRubberDuck()
        {
            return new RubberDuck();
        }

        public override IQuackable CreateDuckDecoy()
        {
            return new DuckDecoy();
        }
    }
}