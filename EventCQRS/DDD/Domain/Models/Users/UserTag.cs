using Domain.Models.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.Users
{
   public class UserTag
    {
        public int Id { get;private set; }

        public int UserId { get; private set; }


        public int TagId { get; private set; }



        public UserTag(int id, int userId, int tagId)
        {
            Id = id;
            UserId = userId;
            TagId = tagId;
        }
    }
}
