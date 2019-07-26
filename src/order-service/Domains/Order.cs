using System;
using System.Collections.Generic;

namespace order_service.Domains{
    public class Order
    {
        public Guid Id {get; private set;}
        public List<OrderItem> OrderItems{get; private set;}

        public Order(List<OrderItem> orderItems)
        {
            this.Id = Guid.NewGuid();
            this.OrderItems = orderItems;
        }
    }
}
