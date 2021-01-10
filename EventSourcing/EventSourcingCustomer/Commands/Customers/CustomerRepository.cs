using Domain.Customers.Entities;
using Domain.Customers.Repositories;
using Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Commands.Customers
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IEventStore eventStore;

        public CustomerRepository(IEventStore eventStore)
        {
            this.eventStore = eventStore;
        }

        public async Task<Customer> GetCustomer(Guid id)
        {
            var customerEvents = await eventStore.LoadAsync(id, typeof(Customer).Name);
            return new Customer(customerEvents);

        }

        public async Task<Guid> SaveAsync(Customer customers)
        {
            await eventStore.SaveAsync(customers.Id, customers.GetType().Name, customers.Version, customers.DomainEvents);
            return customers.Id;
        }
    }
}
