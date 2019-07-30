using System.Collections;
using System.Collections.Generic;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrdersApi.Controllers;
using OrdersApi.Models;

namespace OrdersApi.UnitTests
{
    [TestClass]
    public class OrdersControllerTests
    {
        [TestMethod]
        public void GetShouldReturnOrders()
        {
            //arrange
            OrdersController controller = new OrdersController();

            //act
            ActionResult<IEnumerable<Order>> result = controller.GetOrders();

            //assert
            result.Value.Should().BeEquivalentTo(
                new Order("a", 123),
                new Order("b", 456));
        }
    }
}