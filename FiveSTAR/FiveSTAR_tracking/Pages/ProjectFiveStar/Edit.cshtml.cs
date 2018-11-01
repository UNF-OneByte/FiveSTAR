using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FiveSTAR_tracking.Models;

namespace FiveSTAR_tracking.Pages.ProjectFiveStar
{
    public class EditModel : PageModel
    {
        private readonly FiveSTAR_tracking.Models.ProjectTaskContext _context;

        public EditModel(FiveSTAR_tracking.Models.ProjectTaskContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ProjectsFiveStar).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProjectsFiveStarExists(ProjectsFiveStar.ID))
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

        private bool ProjectsFiveStarExists(string id)
        {
            return _context.ProjectFiveStar.Any(e => e.ID == id);
        }
    }
}
