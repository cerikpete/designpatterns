using System.Collections.Generic;

namespace DuckLibrary.Observers
{
    public class ShiftManager : IObservable
    {
        private List<IObserver> observers = new List<IObserver>();
        private IFarmer currentFarmer;

        public void RegisterObserver(IObserver observerToRegister)
        {
            observers.Add(observerToRegister);
        }

        public void ChangeFarmer(IFarmer farmerToChangeTo)
        {
            currentFarmer = farmerToChangeTo;
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(currentFarmer);
            }
        }
    }
}