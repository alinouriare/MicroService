using Domain.Contracts;
using Domain.Events.Orders;
using Domain.Models.Users;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.EventHandlers.Orders
{
    public class OrderAddEventHandler : INotificationHandler<OrderAddEvent>
    {
        private readonly IUserRepository  userRepository;

        public OrderAddEventHandler(IUserRepository  userRepository)
        {
            this.userRepository = userRepository;
        }
        public async Task Handle(OrderAddEvent notification, CancellationToken cancellationToken)
        {
            CustomIdentityUser user =await userRepository.Get(notification.UserId);
            user.UpdatePurchasedNumber();
            await userRepository.Save(user);

           
        }
    }
}
