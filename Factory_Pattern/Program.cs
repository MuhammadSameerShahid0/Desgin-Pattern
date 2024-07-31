using Factory_Pattern.Interfaces;

class program
{
    public static void Main(string[] args)
    {
        //PizzaFactory pizzaFactory = new PizzaFactory();

        //string input = null;
        //Console.WriteLine("Enter The Pizza Name");
        //input=  Console.ReadLine();

        //IPizza pizza = PizzaFactory.GetPizza(input);
        //Console.WriteLine("Type of " + pizza.Name());
        //Console.WriteLine("Price of " + pizza.Price());

        PizzaFactory factory = new PizzaFactory();

        IPizza pizza1 = factory.GetPizza("MARGHERITA");
        Console.WriteLine($"Name is : {pizza1.Name()} , and price is {pizza1.Price()}");

        IPizza pizza2 = factory.GetPizza("PEPPERONI");
        Console.WriteLine($"Name is : {pizza2.Name()} , and price is {pizza2.Price()}");
    }
}