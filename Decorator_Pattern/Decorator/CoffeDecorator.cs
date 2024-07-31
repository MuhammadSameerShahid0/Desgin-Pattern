using Decorator_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Decorator
{
    public abstract class CoffeDecorator : ICoffe
    {
        protected ICoffe _coffee;
        protected CoffeDecorator(ICoffe coffee)
        {
            _coffee = coffee;
        }
        public virtual string Description()
        {
            return _coffee.Description();
        }
        public virtual int Price()
        {
            return _coffee.Price();
        }
    }
}
