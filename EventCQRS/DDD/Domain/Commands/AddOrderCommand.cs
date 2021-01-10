using Domain.CommandResults;
using Domain.Models.Orders;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Commands
{
   public class AddOrderCommand:IRequest<AddOrderResult>
    {
        public int Id { get;  set; }

        public int UserId { get;  set; }
        public DateTime CreateAt { get;  set; }

        public List<OrderItemComment>  OrderItems { get; set; }

    }
    public class OrderItemComment
    {
        public int Id { get;  set; }

        public int OrderId { get;  set; }

        public int ProductId { get;  set; }

        public decimal Price { get;  set; }


    
    }
}
