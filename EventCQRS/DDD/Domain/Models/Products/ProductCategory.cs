using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.Products
{
   public class ProductCategory
    {

        public short Id { get; private set; }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public ProductCategory()
        {

        }
        public ProductCategory(short id, string name, string description):this()
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}
