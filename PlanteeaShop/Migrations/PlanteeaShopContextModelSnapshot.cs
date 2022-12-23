﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlanteeaShop.Data;

#nullable disable

namespace PlanteeaShop.Migrations
{
    [DbContext(typeof(PlanteeaShopContext))]
    partial class PlanteeaShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PlanteeaShop.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ProductOriginID")
                        .HasColumnType("int");

                    b.Property<int?>("SellerID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ProductOriginID");

                    b.HasIndex("SellerID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("PlanteeaShop.Models.ProductOrigin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("OriginName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("ProductOrigin");
                });

            modelBuilder.Entity("PlanteeaShop.Models.Seller", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("SellerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("PlanteeaShop.Models.Product", b =>
                {
                    b.HasOne("PlanteeaShop.Models.ProductOrigin", "ProductOrigin")
                        .WithMany("Products")
                        .HasForeignKey("ProductOriginID");

                    b.HasOne("PlanteeaShop.Models.Seller", "Seller")
                        .WithMany("Products")
                        .HasForeignKey("SellerID");

                    b.Navigation("ProductOrigin");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("PlanteeaShop.Models.ProductOrigin", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("PlanteeaShop.Models.Seller", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
