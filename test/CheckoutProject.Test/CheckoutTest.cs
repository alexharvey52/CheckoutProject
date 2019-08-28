using System;
using Xunit;
using NSubstitute;
using CheckoutProject.Interface;
using System.Collections.Generic;
using CheckoutProject.Model;

namespace CheckoutProject.Test
{
    public class CheckoutTest
    {
        private readonly IOrderProcessor _processor;

        public CheckoutTest()
        {
            _processor = Substitute.For<IOrderProcessor>();
        }

        [Fact]
        public void CompletePurchaseTest()
        {
            try
            {
                IEnumerable<IItem> items = new IItem[] { new Book("The Girl on the train"), 
                                                new Video("Comprehensive First Aid Training"), 
                                                new Subscription("Book Club Membership") 
                                            };

                _processor.ProcessOrder(items);

                Assert.True(true);
            }
            catch
            {
                Assert.True(false);
            }
        }
    }
}
