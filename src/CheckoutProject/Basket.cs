using System;
using CheckoutProject.Model;
using CheckoutProject.Interface;

namespace CheckoutProject
{
    public class Basket
    {
        private readonly IOrderProcessor _processor;

        public Basket(IOrderProcessor processor)
        {
            _processor = processor;
        }

        public void CompletePurchase(PurchaseOrderModel model)
        {
            _processor.ProcessOrder(model.Items);
        }
    }
}
