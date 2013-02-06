namespace DuckLibrary.Observers
{
    public interface IObservable
    {
        void RegisterObserver(IObserver observerToRegister);
        void NotifyObservers();
    }
}