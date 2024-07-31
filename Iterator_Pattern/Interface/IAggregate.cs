using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern.Interface
{
    public interface IAggregate<T>
    {
        IIterator<T> CreateInterface();
    }
}
