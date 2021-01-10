using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.Orders
{
  public  class OrderItem
    {
        public int Id { get; private set; }

        public int OrderId { get; private set; }

        public int ProductId { get; private set; }

        public decimal   Price { get; private set; }


        public OrderItem(int id, int orderId, int productId, decimal price)
        {
            Id = id;
            OrderId = orderId;
            ProductId = productId;
            Price = price;
        }
    }
}
