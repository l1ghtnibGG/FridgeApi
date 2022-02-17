using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Configuration
{
    class FridgeModelConfiguration : IEntityTypeConfiguration<FridgeModel>
    {
        public void Configure(EntityTypeBuilder<FridgeModel> builder)
        {
            builder.HasData(
                new FridgeModel
                {
                    Id = new Guid("48250ce5-86e9-46be-9e07-e71c8fc25c52"),
                    Name = "KI39FP60",
                    Year = 2021
                },

                new FridgeModel
                {
                    Id = new Guid("0685ac44-3c7b-447d-871a-ab0a35f46fbf"),
                    Name = "GR-N309 LLB",
                    Year = 2022
                },

                new FridgeModel
                {
                    Id = new Guid("ea764e6f-4e50-4576-bb65-de9ac6372d0c"),
                    Name = "RB30J3000WW",
                    Year = 2021
                }
            );
        }
    }
}
