using System;

namespace DuckLibrary.Observers
{
    public class FarmerBill : IFarmer
    {
        public string Name
        {
            get { return "Bill"; }
        }

        public bool IsStrict
        {
            get { return true; }
        }
    }
}