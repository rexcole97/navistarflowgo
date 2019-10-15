using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace noviflowgo.Pages.Region
{
    public class DetailsModel : PageModel
    {
        private readonly noviflowgo.Data.ApplicationDbContext _context;

        public DetailsModel(noviflowgo.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
