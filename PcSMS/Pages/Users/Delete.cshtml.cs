using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PcSMS.Data;
using PcSMS.Utility;

namespace PcSMS
{
    [Authorize(Roles = Who.Admin)]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public IdentityUser IdentityUser { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id.Trim().Length == 0)
            {
                return NotFound();
            }

            IdentityUser = await _db.IdentityUser.FirstOrDefaultAsync(m => m.Id == id);

            if (IdentityUser == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var userInDb = await _db.Users.SingleOrDefaultAsync(u => u.Id == IdentityUser.Id);

            _db.Users.Remove(userInDb);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}