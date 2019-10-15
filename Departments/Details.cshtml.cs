using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace noviflowgo.Pages.Departments
{
    public class DetailsModel : PageModel
    {
        private readonly noviflowgo.Data.ApplicationDbContext _context;

        public DetailsModel(noviflowgo.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public departments departments { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            departments = await _context.departments.FirstOrDefaultAsync(m => m.DID == id);

            if (departments == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
