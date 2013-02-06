using DuckLibrary.Ducks;

namespace DuckLibrary.Factories
{
    public abstract class AbstractDuckFactory
    {
        public abstract IQuackable CreateMallardDuck();
        public abstract IQuackable CreateRubberDuck();
        public abstract IQuackable CreateDuckDecoy();
    }
}