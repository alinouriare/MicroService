using Domain.Contracts;
using Domain.Models.Products;
using Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
   public class ProductRepository: IProductRepository
    {
        private readonly APPContext context;

        public ProductRepository(APPContext context)
        {
            this.context = context;
        }

        public async Task Add(Product product)
        {
            await context.Products.AddAsync(product);
            await  context.SaveChangesAsync();
        }

        public async Task<Product>  Get(int id)
        {
             var product= await  context.Products.FirstOrDefaultAsync(c=>c.Id==id);
            return product;

        }

        public async Task Save(Product product)
        {
            context.Products.Update(product);
           await context.SaveChangesAsync();
        }
    }
}
