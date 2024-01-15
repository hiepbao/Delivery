using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Pattern
{
    public interface IProxy
    {
        bool IsValid(string username);
    }
}
