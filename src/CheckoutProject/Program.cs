using System;
using System.Collections.Generic;
using CheckoutProject.Interface;
using CheckoutProject.Model;
using CheckoutProject.Processor;

namespace CheckoutProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Basket basket = new Basket(new CheckoutProcessor());

            IEnumerable<IItem> items = new IItem[] { new Book("The Girl on the train"), 
                                                     new Video("Comprehensive First Aid Training"), 
                                                     new Subscription("Book Club Membership") 
                                                    };

            basket.CompletePurchase(new PurchaseOrderModel()
            {
                PurchaseOrderId = 3344656,
                Total = 48.50m,
                Items = items,
                CustomerId = 4567890
            });
        }
    }
}
