using System;

namespace CheckoutProject.Interface
{
    public interface IItem
    {
        long ItemId {get;set;}
        string ItemName {get;set;}
        int ProductType {get;set;}
    }
}
