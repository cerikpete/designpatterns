using DuckLibrary.Aggregates;

namespace DuckLibrary.Sorter
{
    public class NameSorter : IDuckSorter
    {
        private readonly DuckFlock flockToSort;

        public NameSorter(DuckFlock flockToSort)
        {
            this.flockToSort = flockToSort;
        }

        public void Sort()
        {
            flockToSort.Ducks.Sort((duck1, duck2) => duck1.Name.CompareTo(duck2.Name));
        }
    }
}