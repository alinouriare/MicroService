using Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Customers.DomainEvents
{
   public class AddressChanged: IDomainEvent
    {
        public string City { get; }
        public string Country { get; }
        public string ZipCode { get; }
        public string Street { get; }
        public string CustomerId { get; }

        public AddressChanged(string city, string country, string zipCode, string street, string customerId)
        {
            City = city;
            Country = country;
            ZipCode = zipCode;
            Street = street;
            CustomerId = customerId;
        }
    }
}
