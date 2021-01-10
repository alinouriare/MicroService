using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.Products
{
  public  class ProductTag
    {

        public int Id { get; private set; }

        public int ProductId { get; private set; }

        public int TagId { get; private set; }

        public ProductTag(int id, int productId, int tagId)
        {
            Id = id;
            ProductId = productId;
            TagId = tagId;
        }
    }
}
