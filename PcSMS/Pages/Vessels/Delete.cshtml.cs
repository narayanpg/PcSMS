using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PcSMS.Data;
using PcSMS.Models;
using PcSMS.Utility;

namespace PcSMS.Pages.Vessels
{
    [Authorize(Roles = Who.AdminAndStaff)]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        [TempData]
        public string StatusMessage { get; set; }

        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Vessel Vessel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Vessel = await _db.Vessel
                .Include(c => c.ApplicationUser).FirstOrDefaultAsync(m => m.Id == id);

            if (Vessel == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (Vessel == null)
            {
                return NotFound();
            }
            var userId = Vessel.UserId;

            _db.Vessel.Remove(Vessel);
            await _db.SaveChangesAsync();
            StatusMessage = "Vessel deleted successfully.";
            return RedirectToPage("./Index", new { userId });
        }
    }
}