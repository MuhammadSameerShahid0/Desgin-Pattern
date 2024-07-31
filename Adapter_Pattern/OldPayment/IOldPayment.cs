using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.OldPayment
{
    public interface IOldPayment
    {
        void PaymentProcess(decimal amount);
    }
}
