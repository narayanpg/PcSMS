using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PcSMS.Models
{
    public class ServiceHeader
    {
        public int Id { get; set; }
        
        [Required]
        public double TotalPrice { get; set; }
        public string Details { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:MMM dd yyyy}")]
        public DateTime DateAdded { get; set; }

        public int VesselId { get; set; }

        [ForeignKey("VesselId")]
        public virtual Vessel Vessel { get; set; }
    }
}
