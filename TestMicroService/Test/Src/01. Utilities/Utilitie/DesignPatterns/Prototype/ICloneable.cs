using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitie.DesignPatterns.Prototype
{
    public interface ICloneable<T>
    {
        T Clone();
    }
}
