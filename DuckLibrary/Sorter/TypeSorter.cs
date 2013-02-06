using DuckLibrary.Aggregates;

namespace DuckLibrary.Sorter
{
    public class TypeSorter : IDuckSorter
    {
        private readonly DuckFlock flockToSort;

        public TypeSorter(DuckFlock flockToSort)
        {
            this.flockToSort = flockToSort;
        }

        public void Sort()
        {
            flockToSort.Ducks.Sort((duck1, duck2) => duck1.GetType().ToString().CompareTo(duck2.GetType().ToString()));
        }
    }
}