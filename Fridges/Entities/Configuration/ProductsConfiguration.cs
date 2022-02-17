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
                    Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                    Name = "Banana",
                    DefaultQuantity = 5
                },
                new Products
                {
                    Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                    Name = "Meat",
                    DefaultQuantity = 2
                },
                new Products
                {
                    Id = new Guid("f08adfd1-1449-4812-926d-65f60a71491a"),
                    Name = "Milk",
                    DefaultQuantity = 1
                }
            );
        }
    }
}
