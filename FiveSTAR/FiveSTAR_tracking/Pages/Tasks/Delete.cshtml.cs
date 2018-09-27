using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FiveSTAR_tracking.Models;

namespace FiveSTAR_tracking.Pages.Tasks
{
    public class DeleteModel : PageModel
    {
        private readonly FiveSTAR_tracking.Models.ProjectsContext _context;

        public DeleteModel(FiveSTAR_tracking.Models.ProjectsContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Projects Projects { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Projects = await _context.Projects.FirstOrDefaultAsync(m => m.ID == id);

            if (Projects == null)
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

            Projects = await _context.Projects.FindAsync(id);

            if (Projects != null)
            {
                _context.Projects.Remove(Projects);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
