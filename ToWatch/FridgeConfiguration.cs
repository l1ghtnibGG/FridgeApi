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
                    Id = Guid.NewGuid(),
                    Name = "Siemens",
                    OwnerName = "Sasha"
                },
                new Fridge
                {
                    Id = Guid.NewGuid(),
                    Name = "LG",
                    OwnerName = "Vika"
                },
                new Fridge
                {
                    Id = Guid.NewGuid(),
                    Name = "Samsung",
                    OwnerName = "Petr"
                }
                );
        }
    }
}
