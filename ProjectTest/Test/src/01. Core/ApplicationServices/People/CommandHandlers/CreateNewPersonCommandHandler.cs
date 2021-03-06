﻿using ApplicationServices.People.Commands;
using CoreDomain.People.Entities;
using CoreDomain.People.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Zamin.Core.Domain.TacticalPatterns;

namespace ApplicationServices.People.CommandHandlers
{
   public class CreateNewPersonCommandHandler
    {
        private readonly IPersonCommandRepository personCommandRepository;

        public CreateNewPersonCommandHandler(IPersonCommandRepository personCommandRepository)
        {
            this.personCommandRepository = personCommandRepository;
        }

        public void Handle(CreateNewPersonCommand command)
        {
            var person = Person.Create(BusinessId.FromGuid(command.Id), command.FirstName, command.LastName);
            personCommandRepository.Add(person);
        }
    }
}
