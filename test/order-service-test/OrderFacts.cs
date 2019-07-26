using System.Collections.Generic;
using System.Linq;
using NHibernate;
using order_service.Domains;
using Xunit;

namespace order_service_test
{
    public class OrderFacts : FactBase
    {
        [Fact]
        public void should_create_order_successfully_and_return_order()
        {
            string productName = "Pen";
            int count = 2;
            var order = new Order (new List<OrderItem>{new OrderItem(productName, count)});
            Assert.NotNull(order.Id);
            Assert.Equal(1, order.OrderItems.Count);
            Assert.Equal(productName, order.OrderItems.First().ProductName);
            Assert.Equal(count, order.OrderItems.First().Count);
        }
    }
}