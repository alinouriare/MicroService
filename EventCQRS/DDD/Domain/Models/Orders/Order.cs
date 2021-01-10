using Domain.Commands;
using Domain.Events.Orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.Orders
{
   public class Order: Entity
    {
        public int Id { get;private set; }

        public int UserId { get; private set; }
        public DateTime CreateAt { get; private set; }

        public Order(int id, int userId, DateTime createAt):this()
        {
            Id = id;
            UserId = userId;
            CreateAt = createAt;
        }

        private readonly List<OrderItem> _orderItems;

        public IReadOnlyCollection<OrderItem> OrderItems => _orderItems;

        public Order()
        {
            _orderItems = new List<OrderItem>();
        }

        public void AddItem(List<OrderItemComment> items)
        {
            foreach (var item in items)
            {
                _orderItems.Add(new OrderItem(0,Id,item.ProductId,item.Price));

                AddDomainEvent(new OrderAddEvent(UserId));
            }
            ///
        }
      
    }
}
