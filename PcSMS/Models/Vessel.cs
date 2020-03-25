using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PcSMS.Models
{
    public class Vessel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string IN { get; set; }
        
        [Required]
        public string Model { get; set; }

        [Required]
        public int Year { get; set; }
        
        public string Color { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
