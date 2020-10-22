using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrderMgmtSystem.Entities;
using OrderMgmtSystem.Helper;
using OrderMgmtSystem.Services;

namespace OrderMgmtSystem.Controllers
{
    [ApiController]
    public class OrderController : ControllerBase
    {
        OrderService order = new OrderService();

        [HttpGet]
        [Route("Place Order/placing an order")]
        public string Get([FromQuery] OrderDetails orderdetails)
        {
            int orderId = order.PlaceOrder(orderdetails);
            string courier= order.ChooseCourier(orderdetails);
            return "Your order has been accepted by  " +  courier                + " " + " and your order Id is :  " + orderId;
        }

    }

}
