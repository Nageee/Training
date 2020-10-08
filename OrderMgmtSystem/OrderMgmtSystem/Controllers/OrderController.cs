using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrderMgmtSystem.Entities;
using OrderMgmtSystem.Services;

namespace OrderMgmtSystem.Controllers
{
    [ApiController]
    public class OrderController : ControllerBase
    {
        OrderService order = new OrderService();

        [HttpGet]
        [Route("Name/GetYourName")]
        public string Get([FromQuery] OrderDetails orderdetails)
        {
            int orderId = order.PlaceOrder(orderdetails);
            return "Your order has been accepted and your order Id is :  " + orderId;
        }

       


    }
}
