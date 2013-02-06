using System.Collections.Generic;
using DuckLibrary.Ducks;
using DuckLibrary.Sorter;

namespace DuckLibrary.Aggregates
{
    public class DuckFlock
    {
        private readonly List<IQuackable> ducks = new List<IQuackable>();

        public void Add(IQuackable duck)
        {
            ducks.Add(duck);
        }

        public List<IQuackable> Ducks
        {
            get { return ducks; }
        }

        public void SortWith(IDuckSorter sorter)
        {
            sorter.Sort();
        }
    }
}