﻿// <auto-generated />
using System;
using Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(APPContext))]
    [Migration("20201221173510_user")]
    partial class user
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Domain.Models.Orders.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Domain.Models.Orders.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("Domain.Models.Products.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId1")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId1");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Domain.Models.Products.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Body")
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSallable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVisible")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<short>("ProductCategoryId")
                        .HasColumnType("smallint");

                    b.Property<string>("Title")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            Body = "body",
                            CreateAt = new DateTime(2020, 12, 21, 21, 5, 9, 596, DateTimeKind.Local).AddTicks(5756),
                            FilePath = "File",
                            ImagePath = "Image",
                            IsDeleted = false,
                            IsSallable = true,
                            IsVisible = true,
                            Price = 10m,
                            ProductCategoryId = (short)1,
                            Title = "Title"
                        });
                });

            modelBuilder.Entity("Domain.Models.Products.ProductCategory", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = (short)1,
                            Description = "Description 1",
                            Name = "Category 1"
                        },
                        new
                        {
                            Id = (short)2,
                            Description = "Description 2",
                            Name = "Category 2"
                        },
                        new
                        {
                            Id = (short)3,
                            Description = "Description 3",
                            Name = "Category 3"
                        },
                        new
                        {
                            Id = (short)4,
                            Description = "Description 4",
                            Name = "Category 4"
                        },
                        new
                        {
                            Id = (short)5,
                            Description = "Description 5",
                            Name = "Category 5"
                        });
                });

            modelBuilder.Entity("Domain.Models.Products.ProductRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductRate");
                });

            modelBuilder.Entity("Domain.Models.Products.ProductTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductTag");
                });

            modelBuilder.Entity("Domain.Models.Tags.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Tag 1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Tag 2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Tag 3"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Tag 4"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Tag 5"
                        });
                });

            modelBuilder.Entity("Domain.Models.Users.CustomIdentityUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTimeOffset?>("BrithDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEmailPublic")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<DateTimeOffset?>("LastVisitDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LoginCount")
                        .HasColumnType("int");

                    b.Property<long>("Mobile")
                        .HasColumnType("bigint");

                    b.Property<string>("PhotoFileName")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<int>("PurchasedNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CustomIdentityUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrithDate = new DateTimeOffset(new DateTime(2020, 12, 21, 21, 5, 9, 604, DateTimeKind.Unspecified).AddTicks(8735), new TimeSpan(0, 3, 30, 0, 0)),
                            CreateAt = new DateTime(2020, 12, 21, 21, 5, 9, 604, DateTimeKind.Local).AddTicks(5450),
                            FirstName = "ali",
                            IsActive = true,
                            IsEmailPublic = true,
                            LastName = "nouri",
                            LastVisitDateTime = new DateTimeOffset(new DateTime(2020, 12, 21, 21, 5, 9, 605, DateTimeKind.Unspecified).AddTicks(3462), new TimeSpan(0, 3, 30, 0, 0)),
                            Location = "",
                            LoginCount = 1,
                            Mobile = 0L,
                            PhotoFileName = "",
                            PurchasedNumber = 0
                        });
                });

            modelBuilder.Entity("Domain.Models.Orders.OrderItem", b =>
                {
                    b.HasOne("Domain.Models.Orders.Order", null)
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Models.Products.Comment", b =>
                {
                    b.HasOne("Domain.Models.Products.Product", null)
                        .WithMany("Comments")
                        .HasForeignKey("ProductId1");
                });

            modelBuilder.Entity("Domain.Models.Products.ProductRate", b =>
                {
                    b.HasOne("Domain.Models.Products.Product", null)
                        .WithMany("ProductRates")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("Domain.Models.Products.ProductTag", b =>
                {
                    b.HasOne("Domain.Models.Products.Product", null)
                        .WithMany("ProductTags")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Models.Orders.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("Domain.Models.Products.Product", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("ProductRates");

                    b.Navigation("ProductTags");
                });
#pragma warning restore 612, 618
        }
    }
}
