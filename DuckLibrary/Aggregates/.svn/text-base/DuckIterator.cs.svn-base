using System.Collections.Generic;
using DuckLibrary.Aggregates;
using DuckLibrary.Ducks;

namespace DuckLibrary.Aggregates
{
    public class DuckIterator : IIterator<IQuackable>
    {
        private readonly List<IQuackable> ducksToIterate;
        private int currentPosition;

        public DuckIterator(DuckFlock flock)
        {
            currentPosition = 0;
            ducksToIterate = flock.Ducks;
        }

        public IQuackable Current()
        {
            if (currentPosition > ducksToIterate.Count- 1)
            {
                return null;
            }
            return ducksToIterate[currentPosition];
        }

        public IQuackable Next()
        {
            currentPosition++;
            if (currentPosition > ducksToIterate.Count - 1)
            {
                return null;
            }
            return ducksToIterate[currentPosition];
        }
    }
}