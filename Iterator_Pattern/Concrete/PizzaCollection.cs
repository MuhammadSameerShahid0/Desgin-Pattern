using Iterator_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern.Concrete
{
    public class PizzaCollection : IAggregate<Pizza>
    {
        private List<Pizza> _pizzas = new List<Pizza>();
        public IIterator<Pizza> CreateInterface()
        {
            return new PizzaIterator(this);
        }
        public int count()
        {
            return _pizzas.Count();
        }
        public void AddPizza(Pizza pizza) 
        { 
            _pizzas.Add(pizza); 
        }
        public Pizza this[int index]
        {
            get { return _pizzas[index]; }
        }
    }
}
