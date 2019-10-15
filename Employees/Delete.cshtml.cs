using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace noviflowgo.Pages.Employees
{
    public class DeleteModel : PageModel
    {
        private readonly noviflowgo.Data.ApplicationDbContext _context;

        public DeleteModel(noviflowgo.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            employee = await _context.employee.FindAsync(id);

            if (employee != null)
            {
                _context.employee.Remove(employee);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
