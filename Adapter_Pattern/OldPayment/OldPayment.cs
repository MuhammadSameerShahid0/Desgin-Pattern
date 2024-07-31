using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.OldPayment
{
    public class OldPayment : IOldPayment
    {
        public void PaymentProcess(decimal amount)
        {
            Console.WriteLine($"Payment ${amount} Processed By Old Payment");
        }
    }
}
