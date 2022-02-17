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
    class ProductsConfiguration : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.HasData(
                new Products
                {
                    Id = Guid.NewGuid(),
                    Name = "Banana",
                    DefaultQuantity = 5
                },
                new Products
                {
                    Id = Guid.NewGuid(),
                    Name = "Meat",
                    DefaultQuantity = 2
                },
                new Products
                {
                    Id = Guid.NewGuid(),
                    Name = "Milk",
                    DefaultQuantity = 1
                }
            );
        }
    }
}
