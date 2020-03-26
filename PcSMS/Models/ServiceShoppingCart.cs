using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PcSMS.Models
{
    public class ServiceShoppingCart
    {
        public int Id { get; set; }
        public int VesselId { get; set; }
        public int ServiceTypeId { get; set; }

        [ForeignKey("VesselId")]
        public virtual Vessel Vessel { get; set; }

        [ForeignKey("ServiceTypeId")]
        public virtual ServiceType ServiceType { get; set; }
    }
}
