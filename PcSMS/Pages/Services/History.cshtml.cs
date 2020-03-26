using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PcSMS.Data;
using PcSMS.Models;

namespace PcSMS.Pages.Services
{
    [Authorize()]
    public class HistoryModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public HistoryModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public List<ServiceHeader> ServiceHeader { get; set; }

        public string UserId { get; set; }

        public async Task OnGet(int vessId)
        {
            ServiceHeader = await _db.ServiceHeader.Include(s => s.Vessel).Include(c => c.Vessel.ApplicationUser).Where(c => c.VesselId == vessId).ToListAsync();

            UserId = _db.Vessel.Where(u => u.Id == vessId).ToList().FirstOrDefault().UserId;
        }
    }
}