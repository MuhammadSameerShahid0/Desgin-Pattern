namespace Decorator_Pattern.Interface
{
    public class ConcreteComponent : ICoffe
    {
        public string Description()
        {
            return "Espresso";
        }

        public int Price()
        {
            return 100;
        }
    }
}
