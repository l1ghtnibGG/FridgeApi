// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fridges.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20220202210816_InitialData")]
    partial class InitialData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.Fridge", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("fridgeId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OwnerName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<Guid>("modelId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("modelId");

                    b.ToTable("Fridges");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1a2ec2ca-7886-4b81-b5ab-30f4ab3e963c"),
                            Name = "Siemens",
                            OwnerName = "Sasha",
                            modelId = new Guid("48250ce5-86e9-46be-9e07-e71c8fc25c52")
                        },
                        new
                        {
                            Id = new Guid("e03fc2b2-ae8d-4fbd-81f6-0fd2402bd412"),
                            Name = "LG",
                            OwnerName = "Vika",
                            modelId = new Guid("0685ac44-3c7b-447d-871a-ab0a35f46fbf")
                        },
                        new
                        {
                            Id = new Guid("cd2876e1-5fe3-43a3-bb79-646c48ae098c"),
                            Name = "Samsung",
                            OwnerName = "Petr",
                            modelId = new Guid("ea764e6f-4e50-4576-bb65-de9ac6372d0c")
                        });
                });

            modelBuilder.Entity("Entities.Models.FridgeModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("fridgeModelId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("FridgeModels");

                    b.HasData(
                        new
                        {
                            Id = new Guid("48250ce5-86e9-46be-9e07-e71c8fc25c52"),
                            Name = "KI39FP60",
                            year = 2021
                        },
                        new
                        {
                            Id = new Guid("0685ac44-3c7b-447d-871a-ab0a35f46fbf"),
                            Name = "GR-N309 LLB",
                            year = 2022
                        },
                        new
                        {
                            Id = new Guid("ea764e6f-4e50-4576-bb65-de9ac6372d0c"),
                            Name = "RB30J3000WW",
                            year = 2021
                        });
                });

            modelBuilder.Entity("Entities.Models.FridgeProducts", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("fridgeProductsId");

                    b.Property<Guid>("fridgeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("productId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("fridgeId");

                    b.HasIndex("productId");

                    b.ToTable("FridgeProducts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("af76494a-5c6f-4fa2-8dd0-3851066d27d9"),
                            fridgeId = new Guid("1a2ec2ca-7886-4b81-b5ab-30f4ab3e963c"),
                            productId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            quantity = 5
                        },
                        new
                        {
                            Id = new Guid("66c493b6-7fe3-496a-a234-5beec9f58b47"),
                            fridgeId = new Guid("1a2ec2ca-7886-4b81-b5ab-30f4ab3e963c"),
                            productId = new Guid("f08adfd1-1449-4812-926d-65f60a71491a"),
                            quantity = 2
                        },
                        new
                        {
                            Id = new Guid("634d3cdd-ff32-49b1-81e0-1c55b1ccad79"),
                            fridgeId = new Guid("e03fc2b2-ae8d-4fbd-81f6-0fd2402bd412"),
                            productId = new Guid("f08adfd1-1449-4812-926d-65f60a71491a"),
                            quantity = 6
                        },
                        new
                        {
                            Id = new Guid("2ce408cc-7448-43c7-8755-cd22370cd8cb"),
                            fridgeId = new Guid("e03fc2b2-ae8d-4fbd-81f6-0fd2402bd412"),
                            productId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            quantity = 6
                        },
                        new
                        {
                            Id = new Guid("89c212ce-4e87-4658-a6a1-ea2eae044df0"),
                            fridgeId = new Guid("e03fc2b2-ae8d-4fbd-81f6-0fd2402bd412"),
                            productId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            quantity = 1
                        },
                        new
                        {
                            Id = new Guid("3336926d-a697-4a77-a074-defe10f02d95"),
                            fridgeId = new Guid("cd2876e1-5fe3-43a3-bb79-646c48ae098c"),
                            productId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            quantity = 10
                        });
                });

            modelBuilder.Entity("Entities.Models.Products", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("productId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("defaultQuantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                            Name = "Banana",
                            defaultQuantity = 5
                        },
                        new
                        {
                            Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                            Name = "Meat",
                            defaultQuantity = 2
                        },
                        new
                        {
                            Id = new Guid("f08adfd1-1449-4812-926d-65f60a71491a"),
                            Name = "Milk",
                            defaultQuantity = 1
                        });
                });

            modelBuilder.Entity("Entities.Models.Fridge", b =>
                {
                    b.HasOne("Entities.Models.FridgeModel", "FridgeModel")
                        .WithMany("Fridges")
                        .HasForeignKey("modelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FridgeModel");
                });

            modelBuilder.Entity("Entities.Models.FridgeProducts", b =>
                {
                    b.HasOne("Entities.Models.Fridge", "Fridge")
                        .WithMany("FridgeProducts")
                        .HasForeignKey("fridgeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Products", "Products")
                        .WithMany("FridgeProducts")
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fridge");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Entities.Models.Fridge", b =>
                {
                    b.Navigation("FridgeProducts");
                });

            modelBuilder.Entity("Entities.Models.FridgeModel", b =>
                {
                    b.Navigation("Fridges");
                });

            modelBuilder.Entity("Entities.Models.Products", b =>
                {
                    b.Navigation("FridgeProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
