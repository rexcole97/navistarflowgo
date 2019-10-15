using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace noviflowgo.Pages.Departments
{
    public class EditModel : PageModel
    {
        private readonly noviflowgo.Data.ApplicationDbContext _context;

        public EditModel(noviflowgo.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(departments).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!departmentsExists(departments.DID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool departmentsExists(int id)
        {
            return _context.departments.Any(e => e.DID == id);
        }
    }
}
