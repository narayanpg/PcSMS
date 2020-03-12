using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PcSMS.Data;

namespace PcSMS
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;


        public IndexModel(ApplicationDbContext db, UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        [BindProperty]
        public List<EditModelUsers> IdentityUserList { get; set; }


        public async Task<IActionResult> OnGet()
        {
            var roles = await _db.Roles.ToListAsync();
            var users = await _db.Users.ToListAsync();
            var userRoles = await _db.UserRoles.ToListAsync();

            var converteduser = users.Select(x => new EditModelUsers
            {
                User = x.Email,
                Id = x.Id,
                Role = roles
                   .Where(y => userRoles.Any(z => z.UserId == x.Id && z.RoleId == y.Id))
                   .Select(y => new UsersRole
                   {
                       Name = y.NormalizedName
                   })
            });

            IdentityUserList = converteduser.ToList();


            return Page();
        }

        public class UsersRole
        {
            public string Name { get; set; }
        }

        public class EditModelUsers
        {
            public string Id { get; set; }
            public string User { get; set; }
            public IEnumerable<UsersRole> Role { get; set; }
        }


    }
}