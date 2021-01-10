using Application.ViewModels;
using Domain.Contracts;
using Domain.Models.Products;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
 public   class ProductService: IProductService
    {

        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<int> Add(AddProductViewModel addProductView)
        {
            var product = new Product(0, addProductView.Title,
                addProductView.Body,DateTime.Now,addProductView.Price,
                addProductView.ImagePath,addProductView.FilePath,addProductView.ProductCategoryId,
                addProductView.IsVisible,false,addProductView.IsSallable);
           await productRepository.Add(product);
            return product.Id;
        }
    }
}
