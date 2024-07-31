using Iterator_Pattern;
using Iterator_Pattern.Concrete;
using Iterator_Pattern.Interface;

class Program
{
    static void Main(string[] args)
    {
        PizzaCollection collection = new PizzaCollection();
        collection.AddPizza(new Pizza("Lazania"));
        collection.AddPizza(new Pizza("Fajita"));
        collection.AddPizza(new Pizza("Pepperoni"));

        IIterator<Pizza> iterator = collection.CreateInterface();

        Console.WriteLine("Pizzas in the collection:");
        while (iterator.HasNext())
        {
            Pizza pizza = iterator.Next();
            Console.WriteLine($"- {pizza.Name}");
        }
    }
}