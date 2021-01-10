using ApplicationServices.People.CommandHandlers;
using ApplicationServices.People.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using Zamin.Core.Domain.TacticalPatterns;
using Shouldly;

namespace IntegrationTests.ApplicationServices.People
{
    public class CreateNewPersonCommandHandlerTests :IClassFixture<PersonCommandRepositoryFixture>
    {
        PersonCommandRepositoryFixture fixture;

        public CreateNewPersonCommandHandlerTests(PersonCommandRepositoryFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void when_pass_valid_Input_value_expect_person_create_and_register_to_databse()
        {
            //Arrange
            var command = new CreateNewPersonCommand
            {
                FirstName = "Ali",
                LastName = "Nouri",
                Id = Guid.NewGuid()
            };

            var commanHandler = new CreateNewPersonCommandHandler(fixture.PersonCommandRepository);

            // Act
            commanHandler.Handle(command);
            //Assert
       
            var person = fixture.DbContext.People.FirstOrDefault(c => c.Id == BusinessId.FromGuid(command.Id));

            person.ShouldNotBeNull();
            person.FirstName.ShouldBe(command.FirstName);
            person.LastName.ShouldBe(command.LastName);
        }
    }
}
