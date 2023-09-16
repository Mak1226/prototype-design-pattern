using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    /// <summary>
    /// Interface with shallowCopy and deepCopy methods
    /// </summary>
    public interface IPrototype
    {
        Person? shallowCopy();
        Person? deepCopy();
    }
}
