using ApplicationServices.People.CommandHandlers;
using ApplicationServices.People.Commands;
using CoreDomain.People.Entities;
using CoreDomain.People.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTest.ApplicationServices.People
{
   public class CreateNewPersonCommandHandlerTests
    {
        [Fact]
        public void when_pass_valid_Input_value_expect_person_create_and_register()
        {
            //Arrange 

            var command = new CreateNewPersonCommand
            {
                FirstName = "Ali",
                LastName = "Nouri",
                Id = Guid.NewGuid()
            };

          
            var moqPersonRepository = new Moq.Mock<IPersonCommandRepository>();
            moqPersonRepository.Setup(c => c.Add(It.IsAny<Person>()));
            var commanHandler = new CreateNewPersonCommandHandler(moqPersonRepository.Object);

            //act
            commanHandler.Handle(command);
            //assert
            moqPersonRepository.Verify(mock => mock.Add(It.IsAny<Person>()), Times.Once());

        }
    }
}
