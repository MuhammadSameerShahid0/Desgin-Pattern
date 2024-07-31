using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern.NewPayment
{
    public interface INewPayment
    {
        void MakePayment(decimal amount);
    }
}
