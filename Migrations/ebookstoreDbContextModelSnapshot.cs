﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ebookstore;

#nullable disable

namespace ebookstore.Migrations
{
    [DbContext(typeof(ebookstoreDbContext))]
    partial class ebookstoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ebookstore.Models.Admin", b =>
                {
                    b.Property<int>("adminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("adminName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("adminId");

                    b.ToTable("admin");
                });

            modelBuilder.Entity("ebookstore.Models.Author", b =>
                {
                    b.Property<int>("authorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("authorName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("authorId");

                    b.ToTable("authors");
                });

            modelBuilder.Entity("ebookstore.Models.Book", b =>
                {
                    b.Property<int>("bookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("bookDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("bookLanguage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("bookPrice")
                        .HasColumnType("int");

                    b.Property<string>("bookTitle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("bookId");

                    b.ToTable("books");
                });

            modelBuilder.Entity("ebookstore.Models.Customer", b =>
                {
                    b.Property<int>("customerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("customerEmail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("customerName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("customerId");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("ebookstore.Models.CustomerMessage", b =>
                {
                    b.Property<string>("customerEmail")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("customerName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("message")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("customerEmail");

                    b.ToTable("customerMessages");
                });

            modelBuilder.Entity("ebookstore.Models.Publisher", b =>
                {
                    b.Property<int>("publisherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("publisherCountry")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("publisherName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("publisherId");

                    b.ToTable("publishers");
                });

            modelBuilder.Entity("ebookstore.Models.ShoppingCart", b =>
                {
                    b.Property<int>("orderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<int>("totalPrice")
                        .HasColumnType("int");

                    b.HasKey("orderId");

                    b.ToTable("shoppingCarts");
                });
#pragma warning restore 612, 618
        }
    }
}