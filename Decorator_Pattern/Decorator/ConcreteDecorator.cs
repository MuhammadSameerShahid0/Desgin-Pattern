using Decorator_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Decorator
{
    public class MilkDecorator : CoffeDecorator
    {
        public MilkDecorator(ICoffe coffee) : base(coffee)
        {
        }

        public override string Description()
        {
            return $"{_coffee.Description()}, Milk";
        }

        public override int Price()
        {
            return _coffee.Price() + 1;
        }
    }

    public class SugarDecorator : CoffeDecorator
    {
        public SugarDecorator(ICoffe coffee) : base(coffee)
        {
        }

        public override string Description()
        {
            return $"{_coffee.Description()}, Sugar";
        }

        public override int Price()
        {
            return _coffee.Price() + 2;
        }
    }

}
