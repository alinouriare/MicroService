using ApplicationServices.People.CommandHandlers;
using ApplicationServices.People.Commands;
using CoreDomain.People.Entities;
using CoreDomain.People.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zamin.Core.Domain.TacticalPatterns;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }
        [HttpGet]

        public IActionResult Get([FromServices] IPersonCommandRepository repository, [FromQuery] Guid id)
        {
            _logger.LogInformation($"Execute at:{DateTime.Now}");
            //System.Threading.Thread.Sleep(10000);
            Person person = repository.Get(BusinessId.FromGuid(id));
            return Ok(new
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                Id = person.Id.Value

            });
        }

        [HttpPost]
        public IActionResult Post([FromServices] CreateNewPersonCommandHandler handler, [FromBody] CreateNewPersonCommand command)
        {
            handler.Handle(command);
            return Ok();
        }


    }
}
