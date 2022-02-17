using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    class FridgeProductsConfiguration : IEntityTypeConfiguration<FridgeProducts>
    {

        public void Configure(EntityTypeBuilder<FridgeProducts> builder)
        {
            builder.HasData(
                 new FridgeProducts
                 {
                     Id = new Guid("af76494a-5c6f-4fa2-8dd0-3851066d27d9"),
                     FridgeId = new Guid("1a2ec2ca-7886-4b81-b5ab-30f4ab3e963c"),
                     ProductId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                     Quantity = 5
                 },
                 new FridgeProducts
                 {
                     Id = new Guid("66c493b6-7fe3-496a-a234-5beec9f58b47"),
                     FridgeId = new Guid("1a2ec2ca-7886-4b81-b5ab-30f4ab3e963c"),
                     ProductId = new Guid("f08adfd1-1449-4812-926d-65f60a71491a"),
                     Quantity = 2
                 },
                 new FridgeProducts
                 {
                     Id = new Guid("634d3cdd-ff32-49b1-81e0-1c55b1ccad79"),
                     FridgeId = new Guid("e03fc2b2-ae8d-4fbd-81f6-0fd2402bd412"),
                     ProductId = new Guid("f08adfd1-1449-4812-926d-65f60a71491a"),
                     Quantity = 6
                 },
                 new FridgeProducts
                 {
                     Id = new Guid("2ce408cc-7448-43c7-8755-cd22370cd8cb"),
                     FridgeId = new Guid("e03fc2b2-ae8d-4fbd-81f6-0fd2402bd412"),
                     ProductId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                     Quantity = 6
                 },
                 new FridgeProducts
                 {
                     Id = new Guid("89c212ce-4e87-4658-a6a1-ea2eae044df0"),
                     FridgeId = new Guid("e03fc2b2-ae8d-4fbd-81f6-0fd2402bd412"),
                     ProductId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                     Quantity = 1
                 },
                 new FridgeProducts
                 {
                     Id = new Guid("3336926d-a697-4a77-a074-defe10f02d95"),
                     FridgeId = new Guid("cd2876e1-5fe3-43a3-bb79-646c48ae098c"),
                     ProductId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                     Quantity = 10
                 }
                 );
        }
    }
}
