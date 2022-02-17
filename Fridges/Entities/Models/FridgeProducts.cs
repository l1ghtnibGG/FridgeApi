using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class FridgeProducts
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Quantity is required field")]
        public int Quantity { get; set; }


        [ForeignKey("Products")]
        public Guid ProductId { get; set; }
        public Products Products { get; set; }


        [ForeignKey("Fridge")]
        public Guid FridgeId { get; set; }
        public Fridge Fridge { get; set; }
    }
}
