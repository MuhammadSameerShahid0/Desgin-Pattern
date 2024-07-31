using Factory_Pattern.Interfaces;

namespace Factory_Pattern.Concrete
{
    public class PepperoniPizza : IPizza
    {
        public string Name()
        {
            return "Pepperoni Pizza";
        }

        public int Price()
        {
            return 1000;
        }
    }
}
