using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PcSMS.Data;
using PcSMS.Utility;

namespace PcSMS.Pages.Users
{
    [Authorize(Roles = Who.AdminAndStaff)]
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
        //public ApplicationUser ApplicationUser { get; set; }
        public UpdateUserRoleViewModel ApplicationUser { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            var roles = await _db.Roles.ToListAsync();
            var users = await _db.ApplicationUser.FirstOrDefaultAsync(m => m.Id == id);


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
                Name = users.Name, 
                PhoneNumber = users.PhoneNumber, 
                Address = users.Address, 
                City = users.City, 
                PostalCode = users.PostalCode,
                selectedRole = _userManager.GetRolesAsync(users).Result[0],
               
                Roles = roles.Select(x => new SelectListItem
                {
                    Value = x.NormalizedName,
                    Text = x.NormalizedName
                })
            };
            ApplicationUser = viewModel;
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
                var userInDb = await _db.ApplicationUser.SingleOrDefaultAsync(u => u.Id == ApplicationUser.Id);
                if (userInDb == null)
                {
                    return NotFound();
                }
                else
                {
                    userInDb.Name = ApplicationUser.Name;
                    userInDb.PhoneNumber = ApplicationUser.PhoneNumber;
                    userInDb.Address = ApplicationUser.Address;
                    userInDb.City = ApplicationUser.City;
                    userInDb.PostalCode = ApplicationUser.PostalCode;

                    await _db.SaveChangesAsync();
                    var previousrole = _userManager.GetRolesAsync(userInDb).Result[0];

                    if (previousrole != ApplicationUser.selectedRole)
                    {
                        await _userManager.AddToRoleAsync(userInDb, ApplicationUser.selectedRole);
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
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string PostalCode { get; set; }
            public string selectedRole { get; set; }
            public IEnumerable<SelectListItem> Roles { get; set; }
        }


    }
}

