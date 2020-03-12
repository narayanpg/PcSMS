using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PcSMS.Data;

namespace PcSMS
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;

        public EditModel(ApplicationDbContext db, UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        [BindProperty]
        public UpdateUserRoleViewModel IdentityUser { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            var roles = await _db.Roles.ToListAsync();
            var users = await _db.IdentityUser.FirstOrDefaultAsync(m => m.Id == id);


            if (id.Trim().Length == 0)
            {
                return NotFound();
            }

            if (users == null)
            {
                return NotFound();
            }

            var viewModel = new UpdateUserRoleViewModel
            {
                Id = id,
                Email = users.Email,
                selectedRole = _userManager.GetRolesAsync(users).Result[0],
                Roles = roles.Select(x => new SelectListItem
                {
                    Value = x.NormalizedName,
                    Text = x.NormalizedName
                })
            };
            IdentityUser = viewModel;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                var userInDb = await _db.IdentityUser.SingleOrDefaultAsync(u => u.Id == IdentityUser.Id);
                if (userInDb == null)
                {
                    return NotFound();
                }
                else
                {
                    userInDb.Email = IdentityUser.Email;
                    await _db.SaveChangesAsync();
                    var previousrole = _userManager.GetRolesAsync(userInDb).Result[0];

                    if (previousrole != IdentityUser.selectedRole)
                    {
                        await _userManager.AddToRoleAsync(userInDb, IdentityUser.selectedRole);
                        await _userManager.RemoveFromRoleAsync(userInDb, previousrole);
                    }

                    return RedirectToPage("Index");
                }
            }
        }
        public class UpdateUserRoleViewModel
        {
            public string Id { get; set; }
            public string Email { get; set; }
            public string selectedRole { get; set; }
            public IEnumerable<SelectListItem> Roles { get; set; }
        }


    }
}