using System;
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
            string productId = "1";
            var order = new Order (new List<OrderItem>{new OrderItem(productName, productId, count)});
            Assert.NotNull(order.Id);
            Assert.Equal(1, order.OrderItems.Count);
            Assert.Equal(productName, order.OrderItems.First().ProductName);
            Assert.Equal(count, order.OrderItems.First().Count);
            Assert.Equal(productId, order.OrderItems.First().ProductId); 
        }

        [Fact]
        public void should_throw_exception_when_create_order_given_more_than_20_items()
        {
            var orderItems = new List<OrderItem>{};
            for(int i = 0; i<=21; i++){
                orderItems.Add(new OrderItem($"productName{i}", "i", 1));
            }
            Assert.Throws<ArgumentException>(() => new Order (orderItems));
        }
    }
}