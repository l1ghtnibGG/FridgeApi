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
    class FridgeConfiguration : IEntityTypeConfiguration<Fridge>
    {
        public void Configure(EntityTypeBuilder<Fridge> builder)
        {
            builder.HasData(
                new Fridge
                {
                    Id = new Guid("1a2ec2ca-7886-4b81-b5ab-30f4ab3e963c"),
                    Name = "Siemens",
                    OwnerName = "Sasha",
                    ModelId = new Guid("48250ce5-86e9-46be-9e07-e71c8fc25c52")
                },
                new Fridge
                {
                    Id = new Guid("e03fc2b2-ae8d-4fbd-81f6-0fd2402bd412"),
                    Name = "LG",
                    OwnerName = "Vika",
                    ModelId = new Guid("0685ac44-3c7b-447d-871a-ab0a35f46fbf")
                },
                new Fridge
                {
                    Id = new Guid("cd2876e1-5fe3-43a3-bb79-646c48ae098c"),
                    Name = "Samsung",
                    OwnerName = "Petr",
                    ModelId = new Guid("ea764e6f-4e50-4576-bb65-de9ac6372d0c")
                }
            );
        }
    }
}
