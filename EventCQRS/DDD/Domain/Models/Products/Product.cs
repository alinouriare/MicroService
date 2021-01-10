using Domain.Commands;
using Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.Products
{
  public  class Product
    {

        public int Id { get;private set; }

        public string Title { get; private set; }

        public string Body { get; private set; }

        public DateTime CreateAt { get; private set; }

        public decimal Price { get; private set; }

        public string ImagePath { get; private set; }
        public string FilePath { get; private set; }

        public short ProductCategoryId { get; private set; }


        public bool IsVisible { get; private set; }

        public bool IsDeleted { get; private set; }

        public bool IsSallable { get; private set; }


        private readonly List<Comment> _comments;
        public IReadOnlyCollection<Comment> Comments => _comments;

        private readonly List<ProductRate> _productRates;
        public IReadOnlyCollection<ProductRate> ProductRates => _productRates;


        private readonly List<ProductTag> _productTags;
        public IReadOnlyCollection<ProductTag> ProductTags => _productTags;
        public Product()
        {

            _comments = new List<Comment>();
            _productRates = new List<ProductRate>();
            _productTags = new List<ProductTag>();
        }
        public Product(int id, string title, string body, DateTime createAt, decimal price, string imagePath, string filePath, short productCategoryId, bool isVisible, bool isDeleted, bool isSallable):this()
        {
            Id = id;
            Title = title;
            Body = body;
            CreateAt = createAt;
            Price = price;
            ImagePath = imagePath;
            FilePath = filePath;
            ProductCategoryId = productCategoryId;
            IsVisible = isVisible;
            IsDeleted = isDeleted;
            IsSallable = isSallable;
        }

        public void Update(UpdateProductCommand update)
        {
            //var calPrice = update.Price * 100;
            //if (calPrice > update.Price)
            //    throw new UpdatePriceMore($"More{update.Price} not ");
            Title = update.Title;
            Body = update. Body;
            CreateAt = update.CreateAt;
            Price = update.Price;
            ImagePath = update.ImagePath;
            FilePath = update.FilePath;
            ProductCategoryId = update.ProductCategoryId;
            IsVisible = update.IsVisible;
            IsDeleted = update.IsDeleted;
            IsSallable = update. IsSallable;
        }
    }
}
