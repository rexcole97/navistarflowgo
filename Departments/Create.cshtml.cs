using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace noviflowgo.Pages.Departments
{
    public class CreateModel : PageModel
    {
        private readonly noviflowgo.Data.ApplicationDbContext _context;

        public CreateModel(noviflowgo.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public departments departments { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.departments.Add(departments);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}