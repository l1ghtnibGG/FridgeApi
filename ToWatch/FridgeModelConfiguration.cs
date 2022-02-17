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
                    Name = "KI39FP60",
                    Year= 2021
                },

                new FridgeModel
                {
                    Name = "GR-N309 LLB",
                    Year = 2022
                },

                new FridgeModel
                {
                    Name = "RB30J3000WW",
                    Year = 2021
                }
                );
        }
    }
}
