using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fridges.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FridgeModels",
                columns: new[] { "fridgeModelId", "Name", "year" },
                values: new object[,]
                {
                    { new Guid("48250ce5-86e9-46be-9e07-e71c8fc25c52"), "KI39FP60", 2021 },
                    { new Guid("0685ac44-3c7b-447d-871a-ab0a35f46fbf"), "GR-N309 LLB", 2022 },
                    { new Guid("ea764e6f-4e50-4576-bb65-de9ac6372d0c"), "RB30J3000WW", 2021 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "Name", "defaultQuantity" },
                values: new object[,]
                {
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Banana", 5 },
                    { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "Meat", 2 },
                    { new Guid("f08adfd1-1449-4812-926d-65f60a71491a"), "Milk", 1 }
                });

            migrationBuilder.InsertData(
                table: "Fridges",
                columns: new[] { "fridgeId", "Name", "OwnerName", "modelId" },
                values: new object[] { new Guid("1a2ec2ca-7886-4b81-b5ab-30f4ab3e963c"), "Siemens", "Sasha", new Guid("48250ce5-86e9-46be-9e07-e71c8fc25c52") });

            migrationBuilder.InsertData(
                table: "Fridges",
                columns: new[] { "fridgeId", "Name", "OwnerName", "modelId" },
                values: new object[] { new Guid("e03fc2b2-ae8d-4fbd-81f6-0fd2402bd412"), "LG", "Vika", new Guid("0685ac44-3c7b-447d-871a-ab0a35f46fbf") });

            migrationBuilder.InsertData(
                table: "Fridges",
                columns: new[] { "fridgeId", "Name", "OwnerName", "modelId" },
                values: new object[] { new Guid("cd2876e1-5fe3-43a3-bb79-646c48ae098c"), "Samsung", "Petr", new Guid("ea764e6f-4e50-4576-bb65-de9ac6372d0c") });

            migrationBuilder.InsertData(
                table: "FridgeProducts",
                columns: new[] { "fridgeProductsId", "fridgeId", "productId", "quantity" },
                values: new object[,]
                {
                    { new Guid("af76494a-5c6f-4fa2-8dd0-3851066d27d9"), new Guid("1a2ec2ca-7886-4b81-b5ab-30f4ab3e963c"), new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), 5 },
                    { new Guid("66c493b6-7fe3-496a-a234-5beec9f58b47"), new Guid("1a2ec2ca-7886-4b81-b5ab-30f4ab3e963c"), new Guid("f08adfd1-1449-4812-926d-65f60a71491a"), 2 },
                    { new Guid("634d3cdd-ff32-49b1-81e0-1c55b1ccad79"), new Guid("e03fc2b2-ae8d-4fbd-81f6-0fd2402bd412"), new Guid("f08adfd1-1449-4812-926d-65f60a71491a"), 6 },
                    { new Guid("2ce408cc-7448-43c7-8755-cd22370cd8cb"), new Guid("e03fc2b2-ae8d-4fbd-81f6-0fd2402bd412"), new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), 6 },
                    { new Guid("89c212ce-4e87-4658-a6a1-ea2eae044df0"), new Guid("e03fc2b2-ae8d-4fbd-81f6-0fd2402bd412"), new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), 1 },
                    { new Guid("3336926d-a697-4a77-a074-defe10f02d95"), new Guid("cd2876e1-5fe3-43a3-bb79-646c48ae098c"), new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), 10 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumn: "fridgeProductsId",
                keyValue: new Guid("2ce408cc-7448-43c7-8755-cd22370cd8cb"));

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumn: "fridgeProductsId",
                keyValue: new Guid("3336926d-a697-4a77-a074-defe10f02d95"));

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumn: "fridgeProductsId",
                keyValue: new Guid("634d3cdd-ff32-49b1-81e0-1c55b1ccad79"));

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumn: "fridgeProductsId",
                keyValue: new Guid("66c493b6-7fe3-496a-a234-5beec9f58b47"));

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumn: "fridgeProductsId",
                keyValue: new Guid("89c212ce-4e87-4658-a6a1-ea2eae044df0"));

            migrationBuilder.DeleteData(
                table: "FridgeProducts",
                keyColumn: "fridgeProductsId",
                keyValue: new Guid("af76494a-5c6f-4fa2-8dd0-3851066d27d9"));

            migrationBuilder.DeleteData(
                table: "Fridges",
                keyColumn: "fridgeId",
                keyValue: new Guid("1a2ec2ca-7886-4b81-b5ab-30f4ab3e963c"));

            migrationBuilder.DeleteData(
                table: "Fridges",
                keyColumn: "fridgeId",
                keyValue: new Guid("cd2876e1-5fe3-43a3-bb79-646c48ae098c"));

            migrationBuilder.DeleteData(
                table: "Fridges",
                keyColumn: "fridgeId",
                keyValue: new Guid("e03fc2b2-ae8d-4fbd-81f6-0fd2402bd412"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "productId",
                keyValue: new Guid("f08adfd1-1449-4812-926d-65f60a71491a"));

            migrationBuilder.DeleteData(
                table: "FridgeModels",
                keyColumn: "fridgeModelId",
                keyValue: new Guid("0685ac44-3c7b-447d-871a-ab0a35f46fbf"));

            migrationBuilder.DeleteData(
                table: "FridgeModels",
                keyColumn: "fridgeModelId",
                keyValue: new Guid("48250ce5-86e9-46be-9e07-e71c8fc25c52"));

            migrationBuilder.DeleteData(
                table: "FridgeModels",
                keyColumn: "fridgeModelId",
                keyValue: new Guid("ea764e6f-4e50-4576-bb65-de9ac6372d0c"));
        }
    }
}
