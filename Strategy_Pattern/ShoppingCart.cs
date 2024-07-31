using Strategy_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class ShoppingCart
    {
        private IPaymentStrategy _paymentStrategy;
        public void SetPayment(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }
        public void Checkout(decimal amount)
        {
            _paymentStrategy.Pay(amount);
        }
    }
}
