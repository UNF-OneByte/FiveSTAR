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
    public class DetailsModel : PageModel
    {
        private readonly FiveSTAR_tracking.Models.ProjectTaskContext _context;

        public DetailsModel(FiveSTAR_tracking.Models.ProjectTaskContext context)
        {
            _context = context;
        }

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
    }
}
