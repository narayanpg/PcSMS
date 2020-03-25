using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PcSMS.Models.ViewModels
{
    public class UserListViewModel
    {
        public List<ApplicationUser> ApplicationUserList { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
