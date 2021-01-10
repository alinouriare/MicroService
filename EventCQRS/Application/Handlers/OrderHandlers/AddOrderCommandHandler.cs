using Domain.CommandResults;
using Domain.Commands;
using Domain.Contracts;
using Domain.Models.Orders;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlrers.OrderHandlers
{
    public class AddOrderCommandHandler : IRequestHandler<AddOrderCommand, AddOrderResult>
    {
        private readonly IOrderRepository  orderRepository;

        public AddOrderCommandHandler(IOrderRepository  orderRepository)
        {
            this.orderRepository = orderRepository;
        }
        public async Task<AddOrderResult> Handle(AddOrderCommand request, CancellationToken cancellationToken)
        {
            var order = new Order(0, 1,DateTime.Now);
            order.AddItem(request.OrderItems);
            await orderRepository.Save(order);
            return new AddOrderResult();
        }
    }
}
