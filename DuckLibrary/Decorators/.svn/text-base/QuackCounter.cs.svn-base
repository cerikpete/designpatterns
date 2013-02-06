using DuckLibrary.Ducks;

namespace DuckLibrary.Decorators
{
    public class QuackCounter : IQuackable
    {
        private readonly IQuackable duck;
        private static int counter = 0;

        public QuackCounter(IQuackable duck)
        {
            this.duck = duck;
        }

        public void Quack()
        {
            counter++;
            duck.Quack();
        }

        public static int GetNumberOfQuacks()
        {
            return counter;
        }

        public static void ResetQuacks()
        {
            counter = 0;
        }

        public string Name { get; set; }
    }
}