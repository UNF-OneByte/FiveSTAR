using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FiveSTAR_tracking.Models;

namespace FiveSTAR_tracking.Pages.ProjectFiveStar
{
    public class DeleteModel : PageModel
    {
        private readonly FiveSTAR_tracking.Models.ProjectTaskContext _context;

        public DeleteModel(FiveSTAR_tracking.Models.ProjectTaskContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ProjectsFiveStar ProjectsFiveStar { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProjectsFiveStar = await _context.ProjectFiveStar.FirstOrDefaultAsync(m => m.ID == id);

            if (ProjectsFiveStar == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProjectsFiveStar = await _context.ProjectFiveStar.FindAsync(id);

            if (ProjectsFiveStar != null)
            {
                _context.ProjectFiveStar.Remove(ProjectsFiveStar);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
