using Domain.Customers.DomainEvents;
using Domain.Customers.ValueObjects;
using Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Customers.Entities
{
   public class Customer: AggregateRoot
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public Address CustomerAddress { get; private set; }


        private Customer()
        {

        }

        public Customer(IEnumerable<IDomainEvent> events):base(events)
        {

        }
        //factory
        public static Customer CreateCustomer(string firstName,
            string lastName)
        {
            //bussines logic
            var customer = new Customer();
            customer.Apply(new CustomerCreated(Guid.NewGuid().ToString(), firstName, lastName));
            return customer;

        }

        public void ChangeName(string firstName,
            string lastName)
        {
            Apply(new CustomerNameChanged(Id.ToString(),firstName, lastName));
        }
        public void ChangeAddress(string street, string country, string zipCode, string city)
        {
            Apply(new AddressChanged(city, country, zipCode, street, Id.ToString()));
        }

        public void On(CustomerCreated @event)
        {
            Id = Guid.Parse(@event.CustomerId);
            FirstName = @event.FirstName;
            LastName = @event.LastName;
        }

        public void On(CustomerNameChanged @event)
        {
            Id = Guid.Parse(@event.CustomerId);
            FirstName = @event.FirstName;
            LastName = @event.LastName;
        }

        public void On(AddressChanged @event)
        {
            CustomerAddress = new Address()
            {
                City = @event.City,
                Country = @event.Country,
                Street = @event.Street,
                ZipCode = @event.ZipCode
            };
        }
    }
}
