using System;
using CheckoutProject.Interface;

namespace CheckoutProject
{
    public class Book : IItem
    {
        public Book()
        {
        }

        public Book(string itemName)
        {
            ItemName = itemName;
        }

        public long ItemId { get; set; }
        public string ItemName { get; set; }
        public int ProductType {get => (int)ProductTypeEnum.Book;}
    }
}
