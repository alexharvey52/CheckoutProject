using System;
using CheckoutProject.Interface;

namespace CheckoutProject
{
    public class Video : IItem
    {
        public Video()
        {
        }

        public Video(string itemName)
        {
            ItemName = itemName;
        }

        public long ItemId { get; set; }
        public string ItemName { get; set; }
        public int ProductType {get => (int)ProductTypeEnum.Video; set => throw new NotImplementedException();}
    }
}
