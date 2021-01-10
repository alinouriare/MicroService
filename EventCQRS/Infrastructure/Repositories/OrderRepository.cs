using Domain.Contracts;
using Domain.Models.Orders;
using Infrastructure.DbContexts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
   public class OrderRepository: IOrderRepository
    {
        private readonly APPContext context;

        public OrderRepository(APPContext context)
        {
            this.context = context;
        }

        public async Task Save(Order order)
        {
          await  context.AddAsync(order);
            await context.SaveEntitiesAsync();
        }
    }
}
