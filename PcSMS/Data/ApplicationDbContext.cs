using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PcSMS.Models;

namespace PcSMS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<IdentityUser> IdentityUser { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<ServiceType> ServiceType { get; set; }
    }
}
