using System;
using System.Collections.Generic;

namespace CheckoutProject.Interface
{
    public interface IOrderProcessor
    {
        void ProcessOrder(IEnumerable<IItem> items);
    }
}
