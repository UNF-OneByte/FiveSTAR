using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FiveSTAR_tracking.Models;

namespace FiveSTAR_tracking.Pages.ProjectTasks
{
    public class DeleteModel : PageModel
    {
        private readonly FiveSTAR_tracking.Models.ProjectTaskContext _context;

        public DeleteModel(FiveSTAR_tracking.Models.ProjectTaskContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ProjectTask ProjectTask { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProjectTask = await _context.ProjectTasks.FirstOrDefaultAsync(m => m.ID == id);

            if (ProjectTask == null)
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

            ProjectTask = await _context.ProjectTasks.FindAsync(id);

            if (ProjectTask != null)
            {
                _context.ProjectTasks.Remove(ProjectTask);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
