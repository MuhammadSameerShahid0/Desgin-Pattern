namespace ObserverPattern.Interfaces
{
    public interface IStockRepository
    {
        void UpdateStockPrice(string stockSymbol, decimal price);
    }
}
