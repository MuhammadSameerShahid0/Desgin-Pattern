using ObserverPattern.Interfaces;

public class Stock : ISubject
{
    private readonly List<IObserver> _observers = new List<IObserver>();

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify(string stockSymbol, decimal price)
    {
        foreach (var observer in _observers)
        {
            observer.update(stockSymbol, price);
        }
    }

    public void SetPrice(string stockSymbol, decimal price)
    {
        // Notify all observers about the price change
        Notify(stockSymbol, price);
    }
}
