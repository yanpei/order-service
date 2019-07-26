using System;

namespace order_service.Domains
{
    public class OrderItem
    {
        public Guid Id {get; private set;}
        public string ProductName {get; private set;}
        
        public string ProductId{get;private set;}
        public int Count{get;private set;}

        public OrderItem(string productName, string productId, int count)
        {
            this.Id = Guid.NewGuid();
            this.ProductName = productName;
            this.ProductId = productId;
            this.Count = count;   
        }
    }
}