using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    // In C# all you need is for collection you want to iterate over to implement IEnumerable<T>.
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }
}
