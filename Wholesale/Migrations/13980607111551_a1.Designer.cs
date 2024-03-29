﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Wholesale.Models;

namespace Wholesale.Migrations
{
    [DbContext(typeof(WholeSale))]
    [Migration("13980607111551_a1")]
    partial class a1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Wholesale.Models.Address", b =>
                {
                    b.Property<int>("addressID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("addressDetail");

                    b.Property<int?>("orderID");

                    b.Property<string>("postalCode");

                    b.Property<int?>("userID");

                    b.HasKey("addressID");

                    b.HasIndex("orderID");

                    b.HasIndex("userID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Wholesale.Models.Order", b =>
                {
                    b.Property<int>("orderID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("addressID");

                    b.Property<string>("condition");

                    b.Property<DateTime>("data");

                    b.Property<decimal>("sendingPrice");

                    b.Property<int?>("userID");

                    b.HasKey("orderID");

                    b.HasIndex("userID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Wholesale.Models.OrderDetail", b =>
                {
                    b.Property<int>("orderDetailID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("orderCount");

                    b.Property<int?>("orderID");

                    b.Property<int?>("productID");

                    b.Property<decimal>("productPrice");

                    b.Property<string>("sendingWay");

                    b.HasKey("orderDetailID");

                    b.HasIndex("orderID");

                    b.HasIndex("productID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Wholesale.Models.Product", b =>
                {
                    b.Property<int>("productID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description");

                    b.Property<bool>("exisitState");

                    b.Property<int>("existingCount");

                    b.Property<decimal>("price");

                    b.Property<int?>("productCategoryID");

                    b.Property<string>("productName");

                    b.HasKey("productID");

                    b.HasIndex("productCategoryID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Wholesale.Models.ProductCategory", b =>
                {
                    b.Property<int>("productCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoryName");

                    b.HasKey("productCategoryID");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("Wholesale.Models.ProductImage", b =>
                {
                    b.Property<int>("productImageID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("productID");

                    b.HasKey("productImageID");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("Wholesale.Models.User", b =>
                {
                    b.Property<int>("userID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email");

                    b.Property<string>("mobile");

                    b.Property<string>("name");

                    b.Property<string>("password");

                    b.Property<int?>("usergroupID");

                    b.Property<string>("username");

                    b.HasKey("userID");

                    b.HasIndex("usergroupID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Wholesale.Models.UserGroup", b =>
                {
                    b.Property<int>("usergroupID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("groupName");

                    b.HasKey("usergroupID");

                    b.ToTable("UserGroups");
                });

            modelBuilder.Entity("Wholesale.Models.Address", b =>
                {
                    b.HasOne("Wholesale.Models.Order", "Order")
                        .WithMany("Addresses")
                        .HasForeignKey("orderID");

                    b.HasOne("Wholesale.Models.User", "User")
                        .WithMany("Addresses")
                        .HasForeignKey("userID");
                });

            modelBuilder.Entity("Wholesale.Models.Order", b =>
                {
                    b.HasOne("Wholesale.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("userID");
                });

            modelBuilder.Entity("Wholesale.Models.OrderDetail", b =>
                {
                    b.HasOne("Wholesale.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("orderID");

                    b.HasOne("Wholesale.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("productID");
                });

            modelBuilder.Entity("Wholesale.Models.Product", b =>
                {
                    b.HasOne("Wholesale.Models.ProductCategory", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("productCategoryID");
                });

            modelBuilder.Entity("Wholesale.Models.User", b =>
                {
                    b.HasOne("Wholesale.Models.UserGroup", "UserGroup")
                        .WithMany("Users")
                        .HasForeignKey("usergroupID");
                });
#pragma warning restore 612, 618
        }
    }
}
