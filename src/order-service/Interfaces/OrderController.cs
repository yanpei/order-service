using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using order_service.Applications;

namespace order_service.Controllers
{
    public class OrderController{
        private readonly OrderService orderService;

        public OrderController(OrderService orderService)
        {
            this.orderService = orderService;
        }
     
        [HttpGet]
        public ActionResult CreateOrder(List<OrderItemRequest> orderItemsRequest){
            var order = orderService.CreateOrder(orderItemsRequest);
            return new JsonResult(order);
        }
    }
}