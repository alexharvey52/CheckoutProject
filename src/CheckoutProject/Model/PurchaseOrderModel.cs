using System;
using System.Collections.Generic;
using CheckoutProject.Interface;

namespace CheckoutProject.Model
{
    public class PurchaseOrderModel
    {
        public long PurchaseOrderId {get;set;}
        public decimal Total {get;set;}
        public IEnumerable<IItem> Items {get;set;}
        public long CustomerId { get; set; }
    }
}
