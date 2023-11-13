using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendCodingChallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CheckoutController : ControllerBase
    {
        private readonly ILogger<CheckoutController> _logger;

        public CheckoutController(ILogger<CheckoutController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<ActionResult<Price>> checkout([FromBody] string[] watches)
        {
            long discountedValue = 0;

            var dict = WatchHelper.CalculateWatchCount(watches);

            /* this sequential calculation can be implemented using parallel task library
             * discountedValue, which can accessed by all methods, can be made thread-safe
             * by locking the variable during an update
             */

            /*
             Dictionary object is sent to each and every call to maintain stateless to be thread safe
             During parallel tasking, the same dictionary will be accessed by all methods
             at the same time 
             */
            discountedValue += new Rolex(dict).GetValueAfterDiscount();
            discountedValue += new MichaelKors(dict).GetValueAfterDiscount();
            discountedValue += new Swatch(dict).GetValueAfterDiscount();
            discountedValue += new Casio(dict).GetValueAfterDiscount();

            return new Price(discountedValue);
        }
    }
}
