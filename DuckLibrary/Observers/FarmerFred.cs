using System;

namespace DuckLibrary.Observers
{
    public class FarmerFred : IFarmer
    {
        public string Name
        {
            get { return "Fred"; }
        }

        public bool IsStrict
        {
            get { return false; }
        }
    }
}