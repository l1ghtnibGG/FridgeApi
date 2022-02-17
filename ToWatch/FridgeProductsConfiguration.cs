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
                    Quantity = 5
                },
                new FridgeProducts
                {
                    Quantity = 2
                },
                new FridgeProducts
                {
                    Quantity = 6
                },
                new FridgeProducts
                {
                    Quantity = 6
                },
                new FridgeProducts
                {
                    Quantity = 1
                },
                new FridgeProducts
                {
                    Quantity = 10
                }
                );
        }
    }
}
