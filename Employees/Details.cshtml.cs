using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace noviflowgo.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private readonly noviflowgo.Data.ApplicationDbContext _context;

        public DetailsModel(noviflowgo.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public employee employee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            employee = await _context.employee.FirstOrDefaultAsync(m => m.EID == id);

            if (employee == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
