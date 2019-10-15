using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace noviflowgo.Pages.Region
{
    public class EditModel : PageModel
    {
        private readonly noviflowgo.Data.ApplicationDbContext _context;

        public EditModel(noviflowgo.Data.ApplicationDbContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(regions).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!regionsExists(regions.RID))
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

        private bool regionsExists(int id)
        {
            return _context.regions.Any(e => e.RID == id);
        }
    }
}
