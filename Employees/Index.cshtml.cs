using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace noviflowgo.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly noviflowgo.Data.ApplicationDbContext _context;

        public IndexModel(noviflowgo.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<employee> employee { get; set; }

        public async Task OnGetAsync()
        {
            employee = await _context.employee.ToListAsync();
        }
    }
}
