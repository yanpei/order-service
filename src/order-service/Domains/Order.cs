using System;
using System.Collections.Generic;

namespace order_service.Domains{
    public class Order
    {
        public Guid Id {get; private set;}
        public List<OrderItem> OrderItems{get; private set;}

        public Order(List<OrderItem> orderItems)
        {
            if(orderItems.Count>20){
                throw new ArgumentException("itmes should less than 20");
            }
            this.Id = Guid.NewGuid();
            this.OrderItems = orderItems;
        }
    }
}
