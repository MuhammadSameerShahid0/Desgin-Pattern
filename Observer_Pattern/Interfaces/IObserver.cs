namespace ObserverPattern.Interfaces
{
    public interface IObserver
    {
        void update(string stocksymbol, decimal price);
    }
}
