using System;
using CheckoutProject.Interface;

namespace CheckoutProject
{
    public class Subscription : IItem
    {
        public Subscription()
        {
        }

        public Subscription(string itemName)
        {
            ItemName = itemName;
        }

        public long ItemId { get; set; }
        public string ItemName { get; set; }
        public int ProductType {get => (int)ProductTypeEnum.Subscription; set => throw new NotImplementedException();}
    }
}
