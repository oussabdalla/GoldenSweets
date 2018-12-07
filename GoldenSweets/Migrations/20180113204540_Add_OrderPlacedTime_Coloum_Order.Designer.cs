﻿// <auto-generated />
using GoldenSweets.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace GoldenSweets.Migrations
{
    [DbContext(typeof(GoldenSweetsDbContext))]
    [Migration("20180113204540_Add_OrderPlacedTime_Coloum_Order")]
    partial class Add_OrderPlacedTime_Coloum_Order
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GoldenSweets.Core.Models.Cake", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AllergyInfo");

                    b.Property<int>("CategoryId");

                    b.Property<string>("ImageThumbnailUrl");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("InStock");

                    b.Property<bool>("IsCakeOfTheWeek");

                    b.Property<string>("LongDescription");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("ShortDescription");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Cakes");
                });

            modelBuilder.Entity("GoldenSweets.Core.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("GoldenSweets.Core.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("AddressLine2")
                        .HasMaxLength(255);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("OrderPlacedTime");

                    b.Property<decimal>("OrderTotal");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(6);

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("GoldenSweets.Core.Models.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CakeId");

                    b.Property<int>("OrderId");

                    b.Property<decimal>("Price");

                    b.Property<int>("Qty");

                    b.HasKey("Id");

                    b.HasIndex("CakeId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("GoldenSweets.Core.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CakeId");

                    b.Property<int>("Qty");

                    b.Property<string>("ShoppingCartId")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("CakeId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("GoldenSweets.Core.Models.Cake", b =>
                {
                    b.HasOne("GoldenSweets.Core.Models.Category", "Category")
                        .WithMany("Cakes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GoldenSweets.Core.Models.OrderDetail", b =>
                {
                    b.HasOne("GoldenSweets.Core.Models.Cake", "Cake")
                        .WithMany()
                        .HasForeignKey("CakeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GoldenSweets.Core.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GoldenSweets.Core.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("GoldenSweets.Core.Models.Cake", "Cake")
                        .WithMany()
                        .HasForeignKey("CakeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}