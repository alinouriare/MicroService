using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Person.Controllers
{
    [ApiController]
  
    public class PersonController : ControllerBase
    {
        private static readonly List<Person> people = new List<Person>
            {
                new Person
                {
                    Id =1,
                    FirstName="Ali",
                    LastName = "Nouri"
                },
                                new Person
                {
                    Id =2,
                    FirstName="Esi",
                    LastName = "Palang"
                },
                                                new Person
                {
                    Id =3,
                    FirstName="fatemeh",
                    LastName = "Nouri"
                }
            };


        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("[controller]/{id}")]
        public Person Get(int id = 1)
        {
            return people.FirstOrDefault(c => c.Id == id);
        }
    }
}
