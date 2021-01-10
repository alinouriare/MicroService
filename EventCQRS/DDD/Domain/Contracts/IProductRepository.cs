using Domain.Models.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts
{
   public interface IProductRepository
    {
          Task<Product> Get(int id);

         Task Add(Product product);
        Task Save(Product product);

    }
}
