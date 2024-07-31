class Program
{
    static void Main(string[] args)
    {
        // Create the stock subject
        Stock stock = new Stock();

        // Create observers
        StockObserver observer1 = new StockObserver("Observer 1");
        StockObserver observer2 = new StockObserver("Observer 2");

        // Attach observers to the stock
        stock.Attach(observer1);
        stock.Attach(observer2);

        // Update stock price
        stock.SetPrice("AAPL", 150.00m);
        stock.SetPrice("GOOGL", 2800.00m);

        // Detach an observer
        stock.Detach(observer1);

        // Update stock price again
        stock.SetPrice("MSFT", 300.00m);
    }
}
