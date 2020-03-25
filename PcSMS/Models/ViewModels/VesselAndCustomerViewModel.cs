using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PcSMS.Models.ViewModels
{
    public class VesselAndCustomerViewModel
    {
        public ApplicationUser UserObj { get; set; }
        public IEnumerable<Vessel> Vessels { get; set; }
    }
}
