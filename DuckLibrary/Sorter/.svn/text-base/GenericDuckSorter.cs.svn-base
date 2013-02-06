using System;
using DuckLibrary.Aggregates;
using DuckLibrary.Ducks;

namespace DuckLibrary.Sorter
{
    public class GenericDuckSorter : IGenericSorter<IQuackable>
    {
        private readonly DuckFlock flock;

        public GenericDuckSorter(DuckFlock flock)
        {
            this.flock = flock;
        }

        public void SortFlockBy(Func<IQuackable, object> sortByProperty)
        {
            flock.Ducks.Sort((duck1, duck2) => sortByProperty(duck1).ToString().CompareTo(sortByProperty(duck2).ToString()));
        }
    }
}