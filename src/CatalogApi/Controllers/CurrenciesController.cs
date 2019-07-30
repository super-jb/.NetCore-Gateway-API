using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CatalogApi.Controllers
{
    [Route("api/currencies")]
    [ApiController]
    public class CurrenciesController : ControllerBase
    {
        [HttpGet, Route("")]
        public ActionResult<IEnumerable<string>> GetCurrencies()
        {
            return new [] { "usd", "eur", "yen", "btc" };
        }
    }
}