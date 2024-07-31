using ObserverPattern.Interfaces;
using System;

public class StockObserver : IObserver
{
    private readonly string _name;

    public StockObserver(string name)
    {
        _name = name;
    }

    public void update(string stocksymbol, decimal price)
    {
        Console.WriteLine($"{_name} received update: {stocksymbol} price is now {price}");
    }
}
