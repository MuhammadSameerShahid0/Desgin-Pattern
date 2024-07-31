using Iterator_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern.Concrete
{
    public class PizzaIterator : IIterator<Pizza>
    {
        private PizzaCollection _PizzaCollection;
        private int _CurrentIndex = 0;
        public PizzaIterator(PizzaCollection collection)
        {
            _PizzaCollection = collection;
        }
        public bool HasNext()
        {
            return _CurrentIndex < _PizzaCollection.count();
        }

        public Pizza Next()
        {
            return _PizzaCollection[_CurrentIndex++];
        }
    }
}
