using Domain.CommandResults;
using Domain.Commands;
using Domain.Contracts;
using Domain.Models.Products;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlrers.ProductHandlers
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, AddProductResult>
    {

        private readonly IProductRepository productRepository;

        public AddProductCommandHandler(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public async Task<AddProductResult> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product(0,
                request.Title, request.Body, DateTime.Now, request.Price, request.ImagePath,
                request.FilePath, request.ProductCategoryId, request.IsVisible, request.IsDeleted, request.IsSallable);
            await productRepository.Add(product);
            return new AddProductResult(product.Id);
         }
    }
}
