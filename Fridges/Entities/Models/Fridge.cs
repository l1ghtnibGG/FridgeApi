using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Fridge
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }


        [Required(ErrorMessage = "Name is require field")]
        [MaxLength(50, ErrorMessage = "Max length is 50 characters")]
        public string Name { get; set; }

        [MaxLength(30, ErrorMessage = "Max length is 30 characters")]
        public string OwnerName { get; set; }

        [ForeignKey("FridgeModel")]
        public Guid ModelId { get; set; }
        public FridgeModel FridgeModel { get; set; }


        public ICollection<FridgeProducts> FridgeProducts { get; set; }
    }
}
