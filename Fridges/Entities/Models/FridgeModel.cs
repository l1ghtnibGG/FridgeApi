using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class FridgeModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; } 

        [Required(ErrorMessage = "Name of fridge's model is required")]
        [MaxLength(50, ErrorMessage = "Max length is 50 characters")]
        public string Name { get; set; }

        public int Year { get; set; }

        public ICollection<Fridge> Fridges { get; set; }
    }
}
