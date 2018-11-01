using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FiveSTAR_tracking.Models;

namespace FiveSTAR_tracking.Pages.ProjectTasks
{
    public class EditModel : PageModel
    {
        private readonly FiveSTAR_tracking.Models.ProjectTaskContext _context;

        public EditModel(FiveSTAR_tracking.Models.ProjectTaskContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ProjectTask).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProjectTaskExists(ProjectTask.ID))
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

        private bool ProjectTaskExists(string id)
        {
            return _context.ProjectTasks.Any(e => e.ID == id);
        }
    }
}
