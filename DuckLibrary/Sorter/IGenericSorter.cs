using System;

namespace DuckLibrary.Sorter
{
    public interface IGenericSorter<TypeToSort>
    {
        void SortFlockBy(Func<TypeToSort, object> sortByProperty);
    }
}