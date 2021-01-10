using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationServices.People.Commands
{
    public class CreateNewPersonCommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid Id { get; set; }


    }
}
