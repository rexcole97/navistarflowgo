using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace noviflowgo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<noviflowgo.Pages.Employees.employee> employee { get; set; }
        public DbSet<noviflowgo.Pages.Departments.departments> departments { get; set; }
        public DbSet<noviflowgo.Pages.Region.regions> regions { get; set; }
    }
}
