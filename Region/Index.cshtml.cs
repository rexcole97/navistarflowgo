using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace noviflowgo.Pages.Region
{
    public class IndexModel : PageModel
    {
        private readonly noviflowgo.Data.ApplicationDbContext _context;

        public IndexModel(noviflowgo.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<regions> regions { get; set; }

        public async Task OnGetAsync()
        {
            regions = await _context.regions.ToListAsync();
        }
    }
}
