using Application.Services;
using Application.ViewModels;
using Domain.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        //private readonly IProductService productService;

        //public ProductController(IProductService productService)
        //{
        //    this.productService = productService;
        //}

        //[HttpPost]
        //public async Task<IActionResult> Add([FromBody] AddProductViewModel addProductView)
        //{
        //   var productId= await productService.Add(addProductView);
        //    return Ok(productId);
        //}

        private readonly IMediator mediator;

        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddProductCommand command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateProductCommand command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }
    }


}
