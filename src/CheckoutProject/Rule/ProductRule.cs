using System;
using CheckoutProject.Interface;

namespace CheckoutProject.Rule
{
    public class ProductRule : IRule
    {
        private IItem _item;

        public ProductRule(IItem item)
        {
            _item = item;
        }

        public void CompleteRule()
        {
            GenerateShippingSlip();
        }

        private void GenerateShippingSlip()
        {
            // Generates a shipping slip
        }
    }
}
