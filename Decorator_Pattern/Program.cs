using Decorator_Pattern.Decorator;
using Decorator_Pattern.Interface;

class Program
{
    static void Main(string[] args)
    {
        // Create a base espresso
        ICoffe espresso = new ConcreteComponent();
        Console.WriteLine($"Base Espresso: {espresso.Description()}, Cost: {espresso.Price()}");

        // Add milk to espresso
        ICoffe milkEspresso = new MilkDecorator(espresso);
        Console.WriteLine($"Espresso with Milk: {milkEspresso.Description()}, Cost: {milkEspresso.Price()}");

        // Add sugar to espresso
        ICoffe sugarEspresso = new SugarDecorator(espresso);
        Console.WriteLine($"Espresso with Sugar: {sugarEspresso.Description()}, Cost: {sugarEspresso.Price()}");

        // Add milk and sugar to espresso
        ICoffe milkSugarEspresso = new MilkDecorator(new SugarDecorator(espresso));
        Console.WriteLine($"Espresso with Milk and Sugar: {milkSugarEspresso.Description()}, Cost: {milkSugarEspresso.Price()}");
    }
}
