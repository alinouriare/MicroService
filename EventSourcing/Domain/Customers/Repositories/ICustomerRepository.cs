using Domain.Customers.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Customers.Repositories
{
   public interface ICustomerRepository
    {
        Task<Guid> SaveAsync(Customer customers);

        Task<Customer> GetCustomer(Guid id);

    }
}
