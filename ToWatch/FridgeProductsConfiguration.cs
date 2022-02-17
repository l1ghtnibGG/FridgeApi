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
                    Id = Guid.NewGuid(),
                    Quantity = 5
                },
                new FridgeProducts
                {
                    Id = Guid.NewGuid(),
                    Quantity = 2
                },
                new FridgeProducts
                {
                    Id = Guid.NewGuid(),
                    Quantity = 6
                },
                new FridgeProducts
                {
                    Id = Guid.NewGuid(),
                    Quantity = 6
                },
                new FridgeProducts
                {
                    Id = Guid.NewGuid(),
                    Quantity = 1
                },
                new FridgeProducts
                {
                    Id = Guid.NewGuid(),
                    Quantity = 10
                }
                );
        }
    }
}
