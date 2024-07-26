﻿// <auto-generated />
using System;
using EcommerceStore.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EcommerceStore.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EcommerceStore.Shared.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            Icon = "book",
                            Name = "books",
                            Url = "books"
                        },
                        new
                        {
                            Id = 2,
                            Icon = "book",
                            Name = "glasses",
                            Url = "glasses"
                        },
                        new
                        {
                            Id = 3,
                            Icon = "book",
                            Name = "bikes",
                            Url = "bikes"
                        });
                });

            modelBuilder.Entity("EcommerceStore.Shared.Models.Edition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Editions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Papaer-back"
                        },
                        new
                        {
                            Id = 2,
                            Name = "e-book"
                        },
                        new
                        {
                            Id = 3,
                            Name = "X-master"
                        },
                        new
                        {
                            Id = 4,
                            Name = "pc"
                        },
                        new
                        {
                            Id = 5,
                            Name = "P-hub"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Only-fans"
                        });
                });

            modelBuilder.Entity("EcommerceStore.Shared.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            DateCreated = new DateTime(24, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "this is some amazing product",
                            Image = "urls",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 10.99m,
                            Price = 9.99m,
                            Title = "first product"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            DateCreated = new DateTime(24, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "this is some amazing product",
                            Image = "urls",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 10.99m,
                            Price = 9.99m,
                            Title = "second product"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 4,
                            DateCreated = new DateTime(24, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "this is some amazing product",
                            Image = "urls",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 10.99m,
                            Price = 9.99m,
                            Title = "third product"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 4,
                            DateCreated = new DateTime(24, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "this is some very amazing product",
                            Image = "urls",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 10.99m,
                            Price = 7.99m,
                            Title = "fourth product"
                        });
                });

            modelBuilder.Entity("EditionProduct", b =>
                {
                    b.Property<int>("EditionsId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("EditionsId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("EditionProduct");

                    b.HasData(
                        new
                        {
                            EditionsId = 1,
                            ProductsId = 1
                        },
                        new
                        {
                            EditionsId = 1,
                            ProductsId = 2
                        },
                        new
                        {
                            EditionsId = 1,
                            ProductsId = 3
                        },
                        new
                        {
                            EditionsId = 2,
                            ProductsId = 1
                        },
                        new
                        {
                            EditionsId = 2,
                            ProductsId = 2
                        },
                        new
                        {
                            EditionsId = 3,
                            ProductsId = 3
                        },
                        new
                        {
                            EditionsId = 4,
                            ProductsId = 3
                        },
                        new
                        {
                            EditionsId = 5,
                            ProductsId = 4
                        },
                        new
                        {
                            EditionsId = 6,
                            ProductsId = 4
                        });
                });

            modelBuilder.Entity("EcommerceStore.Shared.Models.Product", b =>
                {
                    b.HasOne("EcommerceStore.Shared.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EditionProduct", b =>
                {
                    b.HasOne("EcommerceStore.Shared.Models.Edition", null)
                        .WithMany()
                        .HasForeignKey("EditionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EcommerceStore.Shared.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
