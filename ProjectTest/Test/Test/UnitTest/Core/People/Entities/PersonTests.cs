﻿using CoreDomain.People.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;
using Zamin.Core.Domain.TacticalPatterns;
using System.Linq;
using CoreDomain.People.Events;
using CoreDomain.People.Exceptions;

namespace UnitTest.Core.People.Entities
{
   public class PersonTests
    {
        [Fact]
        public void when_pass_valid_Input_value_expect_person_create()
        {
            //Arrange
            string firstName = "Ali";
            string lastName = "Nouri";
            BusinessId personId = BusinessId.FromGuid(Guid.NewGuid());


            //Act
            var person = Person.Create(personId, firstName, lastName);
            //Assert

            person.ShouldNotBeNull();
            person.Id.ShouldBe(personId);
            person.FirstName.ShouldBe(firstName);
            person.LastName.ShouldBe(lastName);
            person.GetEvents().Count().ShouldBe(1);
            var @event = person.GetEvents().First();
            @event.ShouldBeOfType<PersonCreated>();
        }
        [Fact]
        public void when_pass_invalid_id_expect_throw_invalid_person_id_exception()
        {
            //Arrange
            string firstName = "Ali";
            string lastName = "Nouri";
            BusinessId personId = null;
            //Act
            var exception = Record.Exception(() => Person.Create(personId, firstName, lastName));
            
            //Assert
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<InvalidPersonIdException>();
        }

    }
}
