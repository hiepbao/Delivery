using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Delivery.Pattern
{
    public interface ICommand
    {
        void Execute();

        void Undo();
    }
}