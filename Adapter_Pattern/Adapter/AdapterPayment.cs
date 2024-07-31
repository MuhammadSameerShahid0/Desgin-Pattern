using Adapter_Pattern.NewPayment;
using Adapter_Pattern.OldPayment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.Adapter
{
    public class AdapterPayment : INewPayment
    {
        private readonly IOldPayment _oldPayment;
        public AdapterPayment(IOldPayment oldPayment)
        {
           _oldPayment = oldPayment;
        }

        public void MakePayment(decimal amount)
        {
            _oldPayment.PaymentProcess(amount);
        }
    }
}
