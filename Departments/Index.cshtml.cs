using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace noviflowgo.Pages.Departments
{
    public class IndexModel : PageModel
    {
        private readonly noviflowgo.Data.ApplicationDbContext _context;

        public IndexModel(noviflowgo.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<departments> departments { get; set; }

        public async Task OnGetAsync()
        {
            departments = await _context.departments.ToListAsync();
        }
    }
}
