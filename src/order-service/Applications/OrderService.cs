using System.Collections.Generic;
using System.Linq;
using order_service.Controllers;
using order_service.Domains;

namespace order_service.Applications{
    public class OrderService{
        static string productId = "1";
        Dictionary<string, string> products = new Dictionary<string, string>{
            {productId, "Pen"}
        };
        Dictionary<string, Inventory> productInventory = new Dictionary<string, Inventory>{
            {productId, new Inventory(productId, 10, 10)}
        };

        public Order CreateOrder(List<OrderItemRequest> orderItemsRequest){
            var orderItems = orderItemsRequest.Select(item => new OrderItem(products[item.ProductId], item.ProductId, item.Count)).ToList();
            var order = new Order(orderItems);
            orderItemsRequest.ForEach(item => productInventory[item.ProductId].DecreaseLockedCount(item.Count));

            return order;
        }
    }
}