using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace noviflowgo.Pages.Region
{
    public class DeleteModel : PageModel
    {
        private readonly noviflowgo.Data.ApplicationDbContext _context;

        public DeleteModel(noviflowgo.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public regions regions { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            regions = await _context.regions.FirstOrDefaultAsync(m => m.RID == id);

            if (regions == null)
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

            regions = await _context.regions.FindAsync(id);

            if (regions != null)
            {
                _context.regions.Remove(regions);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
