using System;
using CheckoutProject.Interface;

namespace CheckoutProject.Rule
{
    public class MembershipRule : IRule
    {
        private IItem _item;

        public MembershipRule(IItem item)
        {
            _item = item;
        }
        
        public void CompleteRule()
        {
            ActivateMembership();
        }

        private void ActivateMembership()
        {
            // Activates the customers membership
        }
    }
}
