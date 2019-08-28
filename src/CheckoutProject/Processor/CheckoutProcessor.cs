using System;
using System.Collections.Generic;
using CheckoutProject.Interface;
using CheckoutProject.Rule;

namespace CheckoutProject.Processor
{
    public class CheckoutProcessor : IOrderProcessor
    {
        public void ProcessOrder(IEnumerable<IItem> items)
        {
            foreach(IItem item in items)
            {
                IRule rule;
                switch(item.ProductType){
                    case (int)ProductTypeEnum.Book: 
                        rule = new ProductRule(item);
                        break;
                    case (int)ProductTypeEnum.Video: 
                        rule = new ProductRule(item);
                        break;
                    case (int)ProductTypeEnum.Subscription: 
                        rule = new MembershipRule(item);
                        break;
                    default:
                        rule = null;
                        break;
                }

                if(rule != null)
                {
                    rule.CompleteRule();
                }
            } 
        }
    }
}
