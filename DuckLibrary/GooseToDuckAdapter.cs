namespace DuckLibrary
{
    public class GooseToDuckAdapter : IQuackable
    {
        private readonly Goose gooseToAdapt;

        public GooseToDuckAdapter(Goose gooseToAdapt)
        {
            this.gooseToAdapt = gooseToAdapt;
        }

        public string Quack()
        {
            return gooseToAdapt.Honk();
        }
    }
}