using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using SrudentPortal.Web.Models.Entities;

namespace SrudentPortal.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            

        }

        public DbSet<Student> Student { get; set; }
    }
}
