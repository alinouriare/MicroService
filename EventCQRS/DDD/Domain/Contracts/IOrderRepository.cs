using Domain.Models.Orders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts
{
   public interface IOrderRepository
    {
        Task Save(Order order);
    }
}
