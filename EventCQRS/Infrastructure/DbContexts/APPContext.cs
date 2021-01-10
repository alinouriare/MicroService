using Domain.Models.Orders;
using Domain.Models.Products;
using Domain.Models.Tags;
using Domain.Models.Users;
using Infrastructure.Extentions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.DbContexts
{
    public  class APPContext:DbContext
    {
       private readonly IMediator _mediator;

        public DbSet<Product>  Products { get; set; }
        public DbSet<ProductCategory>  ProductCategories { get; set; }
        public DbSet<Order>  Orders { get; set; }
        public DbSet<Tag>  Tags { get; set; }
        public DbSet<CustomIdentityUser>  CustomIdentityUsers { get; set; }
        public APPContext()
        {

        }

        public APPContext(DbContextOptions<APPContext> options,IMediator mediator ):base(options)
        {
            _mediator = mediator;
        }


        public async Task<bool> SaveEntitiesAsync()
        {
            await _mediator.DispacherDomainEventAsync(this);

            var result = await base.SaveChangesAsync();
            return true;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CustomIdentityUser>().Property(c => c.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Order>().Property(c => c.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<OrderItem>().Property(c => c.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<ProductCategory>().ToTable("ProductCategories");
            modelBuilder.Entity<ProductCategory>().HasKey(c => c.Id);
            modelBuilder.Entity<ProductCategory>().Property(c => c.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<ProductCategory>().HasData(new List<ProductCategory>() {

            new ProductCategory (1,"Category 1","Description 1"),
              new ProductCategory (2,"Category 2","Description 2"),
              new ProductCategory (3,"Category 3","Description 3"),
               new ProductCategory (4,"Category 4","Description 4"),
               new ProductCategory (5,"Category 5","Description 5")
            });

            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Product>().HasKey(c => c.Id);
            modelBuilder.Entity<Product>().Property(c => c.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Product>().Property(c => c.Title).HasMaxLength(64);
            modelBuilder.Entity<Product>().Property(c => c.Body).HasMaxLength(1024);

            modelBuilder.Entity<Order>().ToTable("Orders");
            modelBuilder.Entity<Order>().HasKey(c => c.Id);
            modelBuilder.Entity<Order>().Property(c => c.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Comment>().ToTable("Comments");
            modelBuilder.Entity<Comment>().HasKey(c => c.Id);
            modelBuilder.Entity<Comment>().Property(c => c.Id).ValueGeneratedOnAdd();



            modelBuilder.Entity<Tag>().ToTable("Tags");
            modelBuilder.Entity<Tag>().HasKey(c => c.Id);
            modelBuilder.Entity<Tag>().Property(c => c.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Tag>().HasData(new List<Tag>() {

              new Tag (1,"Tag 1"),
              new Tag (2,"Tag 2"),
              new Tag (3,"Tag 3"),
               new Tag (4,"Tag 4"),
               new Tag (5,"Tag 5")
            });

            modelBuilder.Entity<Product>().HasData(new List<Product>() {

              new Product (4,"Title","body",DateTime.Now,10,"Image","File",1,true,false,true) });

            modelBuilder.Entity<CustomIdentityUser>().HasData(new List<CustomIdentityUser>() {

              new CustomIdentityUser(){ 
              
              Id=1,
              IsEmailPublic=true,
              CreateAt=DateTime.Now,
              PhotoFileName="",
              IsActive=true,
              BrithDate=DateTime.Now,
              PurchasedNumber=0,
              FirstName="ali",
              LastName="nouri",
              LastVisitDateTime=DateTime.Now,
              Location="",
              LoginCount=1,
              Mobile=00
              } });
              

        }
    }
}
