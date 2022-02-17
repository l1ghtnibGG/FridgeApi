using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Products
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is required field")]
        [MaxLength(30, ErrorMessage = "Max length is 30 characters")]
        public string Name { get; set; }

        public int DefaultQuantity { get; set; }

        public ICollection<FridgeProducts> FridgeProducts { get; set; }
    }
}
