using Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.Products
{
   public class Comment
    {
        public int Id { get; private set; }

        public string ProductId { get; private set; }
        public int UserId { get; private set; }
        public string Body { get; private set; }
        public int? ParentId { get; private set; }

        public DateTime CreateAt { get; private set; }

        public bool IsVerified { get; private set; }

        public Comment(int id, string productId, int userId, string body, int? parentId, DateTime createAt, bool isVerified)
        {
            Id = id;
            ProductId = productId;
            UserId = userId;
            Body = body;
            ParentId = parentId;
            CreateAt = createAt;
            IsVerified = isVerified;
        }

      
    }
}
