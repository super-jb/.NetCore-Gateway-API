using System.Collections.Generic;
using CatalogApi.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatalogApi.UnitTests
{
    [TestClass]
    public class CurrenciesControllerTests
    {
        [TestMethod]
        public void GetShouldReturnCurrencies()
        {
            //arrange
            CurrenciesController controller = new CurrenciesController();

            //act
            ActionResult<IEnumerable<string>> result = controller.GetCurrencies();

            //assert
            result.Value.Should().BeEquivalentTo("usd", "eur", "yen", "btc");
        }
    }
}