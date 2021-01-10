using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.CommandResults
{
   public class AddProductResult
    {
        public AddProductResult(int productId)
        {
            Id = productId;
        }
        public int Id { get; set; }

    }

}
