using Factory_Pattern.Concrete;
using Factory_Pattern.Interfaces;

public class PizzaFactory
{
    public IPizza GetPizza(string pizzaType)
    {
        if (pizzaType.Equals("MARGHERITA"))
        {
            return new MargheritaPizza();
        }
        else if (pizzaType.Equals("PEPPERONI"))
        {
            return new PepperoniPizza();
        }

        return null;
    }
}
