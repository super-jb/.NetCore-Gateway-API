using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OrdersApi.Models;

namespace OrdersApi.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        [HttpGet, Route("")]
        public ActionResult<IEnumerable<Order>> GetOrders()
        {
            var order1 = new Order("a", 123);
            var order2 = new Order("b", 456);

            return new [] { order1, order2 };
        }
    }
}