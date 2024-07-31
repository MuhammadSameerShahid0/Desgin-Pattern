using Factory_Pattern.Interfaces;

namespace Factory_Pattern.Concrete
{
    public class MargheritaPizza : IPizza
    {
        public string Name()
        {
           
            return "Margherita Pizza";
        }

        public int Price()
        {
          
            return 999;
        }
    }
}
