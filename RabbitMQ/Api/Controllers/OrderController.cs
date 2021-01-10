using Contracts;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IRequestClient<OrderRegistered> requestClient;

        private readonly ILogger<OrderController> _logger;


        public OrderController(ILogger<OrderController> logger, IRequestClient<OrderRegistered> requestClient)
        {
            _logger = logger;
            this.requestClient = requestClient;
        }


        [HttpGet]
        public async Task<IActionResult> Get(int id = 1, string customerNumber = "12")
        {
            var (accepted, rejected) = await requestClient.GetResponse<OrderAccepted, OrderRejected>(new OrderRegistered
            {
                CustomerNumber = customerNumber,
                OrderDate = DateTime.Now,
                OrderId = id
            });
            if (accepted.IsCompleted)
                return Ok(await accepted);
            return Ok(await rejected);
        }
    }
}
